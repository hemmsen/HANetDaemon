namespace daemonapp.Handlers
{
    public class CloseWindowInRoomNotificationHandler : INotificationHandler<CloseWindowInRoomNotification>
    {
        private IEntities _entities;
        private IServices _services;
        private IMediator _mediator;
        private IHaContext _haContext;

        public CloseWindowInRoomNotificationHandler(IHaContext haContext, IMediator mediator)
        {
            _entities = new Entities(haContext);
            _services = new Services(haContext);
            _mediator = mediator;
            _haContext = haContext;
        }

        public Task Handle(CloseWindowInRoomNotification notification, CancellationToken cancellationToken)
        {
            var windowArea = new BinarySensorEntity(_haContext, notification.EntityId).Area;
            var notificationMsg = $"Luk vindue i {windowArea}!";
            _services.Notify.MobileAppPixel5(notificationMsg, "Vindue åbent");
            _services.Notify.MobileAppJonnaphone(notificationMsg, "Vindue åbent");
            _mediator.Publish(new SpeakerNotification() { EntityId = _entities.MediaPlayer.TvStue.EntityId, NotificationMessage = notificationMsg }, cancellationToken);
            return Task.CompletedTask;
        }
    }
}
