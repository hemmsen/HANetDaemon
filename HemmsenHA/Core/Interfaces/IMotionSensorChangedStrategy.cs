namespace HemmsenHA.Core.Interfaces
{
    public interface IMotionSensorChangedStrategy
    {
        bool CanHandle(MotionSensorStateActive motionSensorStateChanged);
        Task DoAction(MotionSensorStateActive motionSensorStateChanged);
    }
}
