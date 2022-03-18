namespace HemmsenHA.Infrastructure.NotificationHandlers;
public class MotionSensorStateChangedHandler : INotificationHandler<MotionSensorStateActive>, INotificationHandler<MotionSensorCleared>
{
    private readonly IServices _services;
    private readonly IEntities _entities;
    private readonly IEnumerable<IMotionSensorChangedStrategy> _motionsSensorChangedStrategies;
    public MotionSensorStateChangedHandler(IServices services, IEntities entities, IEnumerable<IMotionSensorChangedStrategy> motionSensorChangedStrategies)
    {
        _services = services;
        _entities = entities;
        _motionsSensorChangedStrategies = motionSensorChangedStrategies;
    }
    public async Task Handle(MotionSensorStateActive notification, CancellationToken cancellationToken)
    {
        var strategy = _motionsSensorChangedStrategies.SingleOrDefault(x => x.CanHandle(notification));
        await strategy.DoAction(notification);
    }

    public Task Handle(MotionSensorCleared notification, CancellationToken cancellationToken)
    {
        _services.Light.TurnOff(ServiceTarget.FromEntity(_entities.Light.BathroomSpotsLevelOnOff.EntityId));
        return Task.CompletedTask;
    }
}