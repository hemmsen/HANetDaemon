namespace HemmsenHA.Infrastructure.Strategies.CarbonDioxide;
public class CarbonDioxideYellowLevelLivingroomStrategy : ICarbonDioxideChangedStrategy
{
    private IEntities _entities;
    private IServices _services;
    private HaConfigOptions _haConfigOptions;
    public CarbonDioxideYellowLevelLivingroomStrategy(IEntities entities, IServices services, IScheduler scheduler, IOptionsSnapshot<HaConfigOptions> optionsSnapshot)
    {
        _entities = entities;
        _services = services;
        _haConfigOptions = optionsSnapshot.Value;
    }

    public bool CanHandle(CarbonDioxideChanged carbonDioxideChanged)
    {
        return carbonDioxideChanged.EntityId == _entities.Sensor.NetatmoEngelstoft157IndoorCo2.EntityId
            && carbonDioxideChanged?.OldEntityState?.State < _haConfigOptions.CO2YellowLow
            && carbonDioxideChanged?.NewEntityState?.State >= _haConfigOptions.CO2YellowLow
            && carbonDioxideChanged?.NewEntityState.State < _haConfigOptions.CO2YellowHigh
            && DateTimeOffset.Now.TimeOfDay < _haConfigOptions.MuteTemperatureNotificationsAfter;
    }

    public async Task DoAction(CarbonDioxideChanged carbonDioxideChanged)
    {
        //Check current light state
        var lightStateLivingroomIsOff = _entities.Light.LivingroomLights.EntityState.IsOff();
        var lightStateKitchenIsOff = _entities.Light.KokkenSpotsLevelOnOff.EntityState.IsOff();

        //Flash lights
        _services.Light.TurnOn(ServiceTarget.FromEntities(_entities.Light.LivingroomLights.EntityId, _entities.Light.KokkenSpotsLevelOnOff.EntityId), new LightTurnOnParameters() { Flash = "short" });

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