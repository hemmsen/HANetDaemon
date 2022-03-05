namespace HemmsenHA.Core.Interfaces;
public interface ITemperatureChangedStrategy
{
    bool CanHandle(ClimateChangedNotification climateChangedNotification);
    void DoAction(ClimateChangedNotification climateChangedNotification);
}