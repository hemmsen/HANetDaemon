
namespace HemmsenHA.Infrastructure.Strategies
{
    public class OpenWindowBedroomStrategy : IWindowStateChangedStrategy
    {
        private Entities entities;
        private IServices services;
        private IScheduler scheduler;
        private IMediator mediator;
        public OpenWindowBedroomStrategy(IHaContext haContext, IScheduler scheduler, IMediator mediator)
        {
            entities = new Entities(haContext);
            this.scheduler = scheduler;
            this.mediator = mediator;
            this.services = new Services(haContext);
        }
        public bool CanHandle(WindowStateChanged windowStateChanged)
        {
            return windowStateChanged.EntityId == entities.BinarySensor.BedroomWindow.EntityId;
        }

        public Task DoAction(WindowStateChanged windowStateChanged)
        {
            // If window is open then turn off the heat!
            if (windowStateChanged.NewEntityState.IsOn())
            {
                services.Climate.SetHvacMode(ServiceTarget.FromEntity(entities.Climate.BedroomThermostatThermostat.EntityId), "off");
                return Task.CompletedTask;
            }
            // If window not open then turn on the heat!
            services.Climate.SetHvacMode(ServiceTarget.FromEntity(entities.Climate.BedroomThermostatThermostat.EntityId), "heat");
            return Task.CompletedTask;
        }
    }
}
