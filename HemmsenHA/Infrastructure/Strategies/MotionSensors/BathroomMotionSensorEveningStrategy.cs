namespace HemmsenHA.Infrastructure.Strategies;
public class BathroomMotionSensorEveningStrategy : IMotionSensorChangedStrategy
{
    private readonly IEntities _entities;
    private readonly IServices _services;
    public BathroomMotionSensorEveningStrategy(IEntities entities, IServices services)
    {
        _entities = entities;
        _services = services;
    }
    public bool CanHandle(MotionSensorStateActive motionSensorStateChanged)
    {
        return motionSensorStateChanged.EntityId == _entities.BinarySensor.MotionBathroomIasZone.EntityId && DateTimeOffset.Now.TimeOfDay > DateTimeOffset.Parse(_entities.Sun.Sun.Attributes.NextDusk).TimeOfDay && DateTimeOffset.Now.TimeOfDay < TimeSpan.FromHours(22);
    }

    public Task DoAction(MotionSensorStateActive motionSensorStateChanged)
    {
        _services.Light.TurnOn(ServiceTarget.FromEntity(motionSensorStateChanged.LightEntityId));
        return Task.CompletedTask;
    }
}
