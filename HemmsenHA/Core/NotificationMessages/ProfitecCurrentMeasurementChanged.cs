namespace daemonapp.Messages
{
    public class ProfitecCurrentMeasurementChanged : INotification
    {
        public double? CurrentPowerConsumption { get; set; }
        public double? OldPowerConsumption { get; set; }
        public DateTimeOffset ReadyDatetimeOffset { get; set; }
    }
}
