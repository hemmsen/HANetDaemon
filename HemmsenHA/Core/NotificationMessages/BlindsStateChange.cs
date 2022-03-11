namespace daemonapp.Messages
{
    public class BlindsStateChange : INotification
    {
        public BlindState BlindState { get; set; }
        public string EntityId { get; set; }
    }

    public enum BlindState
    {
        Closed = 0,
        HaklfClosed = 50,
        Open = 100

    }
}
