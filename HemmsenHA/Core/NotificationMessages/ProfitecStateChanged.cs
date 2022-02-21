namespace daemonapp.Messages
{
    public class ProfitecStateChanged : INotification
    {
        public EntityState<SwitchAttributes>? OldState { get; set; }
        public EntityState<SwitchAttributes>? NewState { get; set; }
        public DateTimeOffset TriggeredDateTime { get; set; } = DateTimeOffset.Now;
    }
}
