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
        return carbonDioxideChanged.EntityId == _entities.Sensor.NetatmoEngelstoft157IndoorCo2.EntityId
            && carbonDioxideChanged?.NewEntityState?.State >= haConfigOptions.CO2GreenHigh
            && carbonDioxideChanged?.NewEntityState.State < haConfigOptions.CO2YellowHigh
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
        if (lightStateLivingroomIsOff)
        {
            _services.Light.TurnOff(ServiceTarget.FromEntity(_entities.Light.LivingroomLights.EntityId));
        }
        if (lightStateKitchenIsOff)
        {
            _services.Light.TurnOff(ServiceTarget.FromEntity(_entities.Light.KokkenSpotsLevelOnOff.EntityId));
        }
    }
}