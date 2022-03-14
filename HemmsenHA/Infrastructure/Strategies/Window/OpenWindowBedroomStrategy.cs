
using System.Globalization;

namespace HemmsenHA.Infrastructure.Strategies
{
    public class OpenWindowBedroomStrategy : IWindowStateChangedStrategy
    {
        private IEntities entities;
        private IServices services;
        private IScheduler scheduler;
        private IMediator mediator;
        private IOptionsMonitor<HaConfigOptions> optionsMonitor;
        private ILogger<OpenWindowBedroomStrategy> logger;
        public OpenWindowBedroomStrategy(IEntities entities, IServices services, IScheduler scheduler, IMediator mediator, IOptionsMonitor<HaConfigOptions> options, ILogger<OpenWindowBedroomStrategy> logger)
        {
            this.entities = entities;
            this.scheduler = scheduler;
            this.mediator = mediator;
            this.services = services;
            this.optionsMonitor = options;
            this.logger = logger;
        }
        public bool CanHandle(WindowStateChanged windowStateChanged)
        {
            return windowStateChanged.EntityId == entities.BinarySensor.BedroomWindow.EntityId;
        }

        public async Task DoAction(WindowStateChanged windowStateChanged)
        {
            // If window is open then turn off the heat!
            if (windowStateChanged.NewEntityState.IsOn())
            {
                services.Climate.SetHvacMode(ServiceTarget.FromEntity(entities.Climate.BedroomThermostatThermostat.EntityId), "off");
                return;
            }
            // If window not open then turn on the heat!
            services.Climate.SetHvacMode(ServiceTarget.FromEntity(entities.Climate.BedroomThermostatThermostat.EntityId), "heat");
            await Task.Delay(5000);
            var haConfigOptions = optionsMonitor.CurrentValue;
            logger.LogInformation("Setting new target temperature for {area} to {targettemp}", entities.Climate.BedroomThermostatThermostat.Area, haConfigOptions.BedroomTemp);
            services.Climate.SetTemperature(ServiceTarget.FromEntity(entities.Climate.BedroomThermostatThermostat.EntityId), haConfigOptions.BedroomTemp);
        }
    }
}
