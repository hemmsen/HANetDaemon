namespace HemmsenHA.Infrastructure.NotificationHandlers;
public class TemperatureChangedHandler : INotificationHandler<ClimateChangedNotification>
{
    private readonly IEnumerable<ITemperatureChangedStrategy> temperatureChangedStrategies;
    private readonly ILogger<TemperatureChangedHandler> logger;

    public TemperatureChangedHandler(IEnumerable<ITemperatureChangedStrategy> temperatureChangedStrategies, ILogger<TemperatureChangedHandler> logger)
    {
        this.temperatureChangedStrategies = temperatureChangedStrategies;
        this.logger = logger;
    }

    public Task Handle(ClimateChangedNotification notification, CancellationToken cancellationToken)
    {
        var strategy = temperatureChangedStrategies.FirstOrDefault(x => x.CanHandle(notification));

        if (strategy != null)
        {
            logger.LogInformation("Chooses strategy for climateNotification with entityId :{entityId} and current temperature: {currentTemp}", notification.EntityId, notification?.NewEntityState?.Attributes?.CurrentTemperature);
            strategy.DoAction(notification);
            return Task.CompletedTask;
        }
        logger.LogError($"There is no strategy for {nameof(ClimateChangedNotification)} with entityId: {notification.EntityId} and new current temperature: {notification?.NewEntityState?.Attributes?.CurrentTemperature}");
        return Task.CompletedTask;
    }
}