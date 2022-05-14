namespace HemmsenHA.Infrastructure.Strategies;
public class ToiletMotionSensorStrategy : IMotionSensorChangedStrategy
{
    private readonly IEntities _entities;
    private readonly IServices _services;
    public ToiletMotionSensorStrategy(IEntities entities, IServices services)
    {
        _entities = entities;
        _services = services;
    }
    public bool CanHandle(MotionSensorStateActive motionSensorStateChanged)
    {
        return motionSensorStateChanged.EntityId == _entities.BinarySensor.MotionToiletIasZone2.EntityId;
    }

    public Task DoAction(MotionSensorStateActive motionSensorStateChanged)
    {
        _services.Light.TurnOn(ServiceTarget.FromEntity(motionSensorStateChanged.LightEntityId));
        return Task.CompletedTask;
    }
}
