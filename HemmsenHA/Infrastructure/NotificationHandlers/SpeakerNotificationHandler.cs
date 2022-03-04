namespace daemonapp.Handlers
{
    public class SpeakerNotificationHandler : INotificationHandler<SpeakerNotification>
    {
        private IServices _services;
        private IEntities _entities;

        public SpeakerNotificationHandler(IHaContext haContext)
        {
            _entities = new Entities(haContext);
            _services = new Services(haContext);
        }

        public async Task Handle(SpeakerNotification notification, CancellationToken cancellationToken)
        {
            if (_entities.Person.Jonna.State.Equals("home") || _entities.Person.Mathias.State.Equals("home"))
            {
                var source = _entities?.MediaPlayer?.TvStue?.Attributes?.Source;
                var volumeLevel = _entities?.MediaPlayer?.TvStue?.Attributes?.VolumeLevel;
                _services.MediaPlayer.VolumeSet(ServiceTarget.FromEntity(notification.EntityId), 0.3);
                await Task.Delay(200, cancellationToken);
                _services.Tts.GoogleTranslateSay(notification.EntityId, notification.NotificationMessage, true, "da");
                await Task.Delay(7000);
                _services.MediaPlayer.VolumeSet(ServiceTarget.FromEntity(notification.EntityId), volumeLevel ?? 0.2);
                _services.MediaPlayer.SelectSource(ServiceTarget.FromEntity(notification.EntityId), source);
            }
        }
    }
}
