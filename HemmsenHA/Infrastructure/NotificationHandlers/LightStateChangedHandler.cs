namespace HemmsenHA.Infrastructure.NotificationHandlers;
public class LightStateChangedHandler : INotificationHandler<LightStateChanged>
{
    public Task Handle(LightStateChanged notification, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
