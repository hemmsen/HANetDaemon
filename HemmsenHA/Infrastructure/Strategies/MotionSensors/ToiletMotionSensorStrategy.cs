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
        return motionSensorStateChanged.EntityId == _entities.BinarySensor.MotionToiletIasZone.EntityId;
    }

    public Task DoAction(MotionSensorStateActive motionSensorStateChanged)
    {
        _services.Light.TurnOn(ServiceTarget.FromEntity(_entities.Light.ToiletOnOff.EntityId));
        return Task.CompletedTask;
    }
}
