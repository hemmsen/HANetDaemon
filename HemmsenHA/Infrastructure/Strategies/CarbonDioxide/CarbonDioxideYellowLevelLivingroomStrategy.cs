namespace HemmsenHA.Infrastructure.Strategies.CarbonDioxide;
public class CarbonDioxideYellowLevelLivingroomStrategy : ICarbonDioxideChangedStrategy
{
    private IEntities _entities;
    private IServices _services;
    private IOptionsMonitor<HaConfigOptions> _optionsMonitor;
    private DateTimeOffset _lastNotificationSendAt;
    public CarbonDioxideYellowLevelLivingroomStrategy(IEntities entities, IServices services, IScheduler scheduler, IOptionsMonitor<HaConfigOptions> optionsMonitor)
    {
        _entities = entities;
        _services = services;
        _optionsMonitor = optionsMonitor;
        _lastNotificationSendAt = DateTimeOffset.MaxValue;
    }

    public bool CanHandle(CarbonDioxideChanged carbonDioxideChanged)
    {
        var haConfigOptions = _optionsMonitor.CurrentValue;
        // only for co2 in livingroom
        return carbonDioxideChanged.EntityId == _entities.Sensor.NetatmoEngelstoft157IndoorCo2.EntityId
            // check if state is higher than threshold
            && carbonDioxideChanged?.NewEntityState?.State >= haConfigOptions.CO2GreenHigh
            // check if below co2 yellow high threshold
            && carbonDioxideChanged?.NewEntityState.State < haConfigOptions.CO2YellowHigh
            // we only want theese notification with an interval set by configuration helper in Home Assistant
            && (_lastNotificationSendAt - carbonDioxideChanged.MeasuredAt) > TimeSpan.FromMinutes(haConfigOptions.NotificationDelayInMinutes);
    }

    public async Task DoAction(CarbonDioxideChanged carbonDioxideChanged)
    {
        //Check current light state
        var lightStateLivingroomIsOff = _entities.Light.LivingroomLights.EntityState.IsOff();
        var lightStateKitchenIsOff = _entities.Light.KokkenSpotsLevelOnOff.EntityState.IsOff();

        //Flash lights
        _services.Light.TurnOn(ServiceTarget.FromEntities(_entities.Light.LivingroomLights.EntityId, _entities.Light.KokkenSpotsLevelOnOff.EntityId), new LightTurnOnParameters() { Flash = "short" });
        _lastNotificationSendAt = DateTimeOffset.Now;
        // Delay to wait for flash to complate
        await Task.Delay(5000);
        //If old state is off then turn off light again
        var lightsToTurnOff = new List<string>();
        if (lightStateLivingroomIsOff)
        {
            lightsToTurnOff.Add(_entities.Light.LivingroomLights.EntityId);
        }
        if (lightStateKitchenIsOff)
        {
            lightsToTurnOff.Add(_entities.Light.LivingroomLights.EntityId);
        }
        _services.Light.TurnOff(ServiceTarget.FromEntities(lightsToTurnOff));
    }
}