namespace HemmsenHA.Core.Interfaces
{
    public interface ICarbonDioxideChangedStrategy
    {
        bool CanHandle(CarbonDioxideChanged carbonDioxideChanged);
        Task DoAction(CarbonDioxideChanged carbonDioxideChanged);
    }
}
