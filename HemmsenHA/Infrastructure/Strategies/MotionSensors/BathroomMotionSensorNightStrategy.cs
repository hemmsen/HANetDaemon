namespace HemmsenHA.Infrastructure.Strategies;
public class BathroomMotionSensorNightStrategy : IMotionSensorChangedStrategy
{
    private readonly IEntities _entities;
    private readonly IServices _services;
    public BathroomMotionSensorNightStrategy(IEntities entities, IServices services)
    {
        _entities = entities;
        _services = services;
    }
    public bool CanHandle(MotionSensorStateActive motionSensorStateChanged)
    {
        return motionSensorStateChanged.EntityId == _entities.BinarySensor.MotionBathroomIasZone.EntityId && DateTimeOffset.Now.TimeOfDay >= TimeSpan.FromHours(22);
    }

    public Task DoAction(MotionSensorStateActive motionSensorStateChanged)
    {
        _services.Light.TurnOn(ServiceTarget.FromEntity(_entities.Light.BathroomSpotsLevelOnOff.EntityId), brightnessPct: 1);
        return Task.CompletedTask;
    }
}
