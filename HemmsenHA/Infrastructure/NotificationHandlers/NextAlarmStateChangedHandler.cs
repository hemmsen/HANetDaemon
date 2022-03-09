namespace HemmsenHA.Infrastructure.NotificationHandlers;
public class NextAlarmStateChangedHandler : INotificationHandler<NextMobileAlarmChanged>
{
    private readonly IEnumerable<INextAlarmOnPhoneChangedStrategy> nextAlarmOnPhoneChangedStrategies;
    public NextAlarmStateChangedHandler(IEnumerable<INextAlarmOnPhoneChangedStrategy> nextAlarmOnPhoneChangedStrategies)
    {
        this.nextAlarmOnPhoneChangedStrategies = nextAlarmOnPhoneChangedStrategies;
    }

    public Task Handle(NextMobileAlarmChanged notification, CancellationToken cancellationToken)
    {
        var strategy = nextAlarmOnPhoneChangedStrategies.SingleOrDefault(x => x.CanHandle(notification));
        if (strategy == null)
        {
            return Task.CompletedTask;
        }
        strategy.DoWork(notification);
        return Task.CompletedTask;
    }
}