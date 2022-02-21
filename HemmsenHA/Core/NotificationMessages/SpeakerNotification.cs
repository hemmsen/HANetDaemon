namespace daemonapp.Messages
{
    public class SpeakerNotification : INotification
    {
        public string NotificationMessage { get; set; }
        public string EntityId { get; set; }
    }
}
