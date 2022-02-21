namespace daemonapp.Messages
{
    public class CloseWindowInRoomNotification : INotification
    {
        public string EntityId { get; set; }
        public double? CurrentTemperature { get; set; }
    }
}
