namespace daemonapp.Handlers
{
    public class ProfitechReadyHandler : INotificationHandler<ProfitecCurrentMeasurementChanged>
    {
        private readonly Entities _entities;
        private readonly ILogger<ProfitechReadyHandler> _logger;
        private readonly HaConfigOptions haConfigOptions;

        public ProfitechReadyHandler(IHaContext context, ILogger<ProfitechReadyHandler> logger, IOptionsSnapshot<HaConfigOptions> optionsSnapshot)
        {
            _entities = new Entities(context);
            _logger = logger;
            this.haConfigOptions = optionsSnapshot.Value;
        }

        public Task Handle(ProfitecCurrentMeasurementChanged notification, CancellationToken cancellationToken)
        {
            if (notification.OldPowerConsumption > haConfigOptions.EspressoReadyPowerConsumption && notification.CurrentPowerConsumption < haConfigOptions.EspressoReadyPowerConsumption)
            {
                _entities.InputBoolean.Profitecready.TurnOn();
                _logger.LogDebug($"Espresso machine is ready!");
            }
            return Task.CompletedTask;
        }
    }
}
