namespace HemmsenHA.Infrastructure.NotificationHandlers;
public class TemperatureChangedHandler : INotificationHandler<ClimateChangedNotification>
{
    private readonly IEnumerable<ITemperatureChangedStrategy> temperatureChangedStrategies;

    public TemperatureChangedHandler(IEnumerable<ITemperatureChangedStrategy> temperatureChangedStrategies)
    {
        this.temperatureChangedStrategies = temperatureChangedStrategies;
    }

    public Task Handle(ClimateChangedNotification notification, CancellationToken cancellationToken)
    {
        var strategy = temperatureChangedStrategies.FirstOrDefault(x => x.CanHandle(notification));

        if (strategy != null)
        {
            strategy.DoAction(notification);
        }
        return Task.CompletedTask;
    }
}