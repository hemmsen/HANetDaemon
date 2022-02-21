namespace daemonapp.Messages
{
    public class VacuumClean : INotification
    {
        public DateTimeOffset TriggederAt { get; set; }
        public int[]? Segments { get; set; } 

    }
}