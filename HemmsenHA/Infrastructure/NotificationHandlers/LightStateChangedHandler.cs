namespace HemmsenHA.Infrastructure.NotificationHandlers;
public class LightStateChangedHandler : INotificationHandler<LightStateChanged>
{
    private readonly IEnumerable<ILightStateChangedStrategy> _lightStateChangedStrategies;
    public LightStateChangedHandler(IEnumerable<ILightStateChangedStrategy> lightStateChangedStrategies)
    {
        _lightStateChangedStrategies = lightStateChangedStrategies;
    }
    public async Task Handle(LightStateChanged notification, CancellationToken cancellationToken)
    {
        var strategy = _lightStateChangedStrategies.FirstOrDefault(x => x.CanHandle(notification));
        if (strategy != null)
        {
            await strategy.DoAction(notification);
        };
    }
}
