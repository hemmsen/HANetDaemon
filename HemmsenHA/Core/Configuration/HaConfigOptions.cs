namespace HemmsenHA.Core.Configuration
{
    public class HaConfigOptions
    {
        public double BedroomTemp{ get; set; }
        public double CO2YellowLow{ get; set; }
        public double CO2YellowHigh { get; set; }
        public double HighTempAlarmBedroom { get; set; }
        public double LowTempAlarmEva { get; set; }
        public double LowTempAlarmBedroom { get; set; }
        public double EspressoReadyPowerConsumption { get; set; }
        public TimeSpan MuteTemperatureNotificationsAfter { get; set; }
    }
}
