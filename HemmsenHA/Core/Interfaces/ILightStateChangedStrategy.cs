namespace HemmsenHA.Core.Interfaces
{
    public interface ILightStateChangedStrategy
    {
        bool CanHandle(LightStateChanged lightStateChanged);
        Task DoAction(LightStateChanged lightStateChanged);
    }
}
