namespace HemmsenHA.Infrastructure.Strategies.CarbonDioxide
{
    public class CarbonDioxideGreenLevelLivingroomStrategy : ICarbonDioxideChangedStrategy
    {
        private IEntities entities;
        private IServices services;
        private HaConfigOptions haConfigOptions;
        public CarbonDioxideGreenLevelLivingroomStrategy(IEntities entities, IServices services, IScheduler scheduler, IMediator mediator, IOptionsSnapshot<HaConfigOptions> options)
        {
            this.entities = entities;
            this.services = services;
            this.haConfigOptions = options.Value;
        }

        public bool CanHandle(CarbonDioxideChanged carbonDioxideChanged)
        {
            return carbonDioxideChanged.EntityId == entities.Sensor.NetatmoEngelstoft157IndoorCo2.EntityId && carbonDioxideChanged?.NewEntityState?.State < haConfigOptions.CO2YellowLow;
        }

        public Task DoAction(CarbonDioxideChanged carbonDioxideChanged)
        {
            return Task.CompletedTask;
        }
    }
}
