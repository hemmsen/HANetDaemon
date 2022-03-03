namespace HemmsenHA.Core.Interfaces;
public interface ITemperatureChangedStrategy
{
    bool CanHandle(ClimateChangedNotification temperatureChangedNotification);
    void DoAction(ClimateChangedNotification temperatureChangedNotification);
}