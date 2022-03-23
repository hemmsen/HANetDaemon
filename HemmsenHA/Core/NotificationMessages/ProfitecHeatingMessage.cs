namespace daemonapp.Messages
{
    public class ProfitecHeatingMessage : INotification
    {
        public NumericEntityState<NumericSensorAttributes> CurrentState { get; set; }
    }
}
