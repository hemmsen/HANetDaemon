namespace daemonapp.Messages
{
    public class BlindsStateChange : INotification
    {
        public int PercentageOpen { get; set; }
        public string EntityId { get; set; }
    }
}
