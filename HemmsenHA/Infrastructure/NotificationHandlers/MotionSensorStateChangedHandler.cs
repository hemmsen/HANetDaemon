namespace HemmsenHA.Infrastructure.NotificationHandlers;
public class MotionSensorStateChangedHandler : INotificationHandler<MotionSensorStateActive>, INotificationHandler<MotionSensorCleared>
{
    private readonly IServices _services;
    private readonly IEntities _entities;
    private readonly IEnumerable<IMotionSensorChangedStrategy> _motionsSensorChangedStrategies;
    private readonly ILogger<MotionSensorStateChangedHandler> _logger;
    public MotionSensorStateChangedHandler(IServices services, IEntities entities, IEnumerable<IMotionSensorChangedStrategy> motionSensorChangedStrategies, ILogger<MotionSensorStateChangedHandler> logger)
    {
        _services = services;
        _entities = entities;
        _motionsSensorChangedStrategies = motionSensorChangedStrategies;
        _logger = logger;
    }
    public async Task Handle(MotionSensorStateActive notification, CancellationToken cancellationToken)
    {
        var strategy = _motionsSensorChangedStrategies.SingleOrDefault(x => x.CanHandle(notification));
        if (strategy == null)
        {
            _logger.LogError("Can't find strategy for motionsensor with entityId: {EntityId}", notification.EntityId);
            return;
        }
        _logger.LogInformation("Found strategy for motion sensor with entityId: {EntityId} and strategyname: {StrategyName}", notification.EntityId, nameof(strategy));
        await strategy.DoAction(notification);
    }

    public Task Handle(MotionSensorCleared notification, CancellationToken cancellationToken)
    {
        _services.Light.TurnOff(ServiceTarget.FromEntity(_entities.Light.BathroomSpotsLevelOnOff.EntityId));
        return Task.CompletedTask;
    }
}