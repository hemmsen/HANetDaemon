namespace HemmsenHA.Core.Interfaces;
public interface INextAlarmOnPhoneChangedStrategy
{
    bool CanHandle(NextMobileAlarmChanged nextMobileAlarmChanged);
    void DoWork(NextMobileAlarmChanged nextMobileAlarmChanged);
}