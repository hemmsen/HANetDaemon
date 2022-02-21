namespace daemonapp.Handlers
{
    public class ProfitechReadyHandler : INotificationHandler<ProfitecCurrentMeasurementChanged>
    {
        private readonly Entities _entities;
        private readonly ILogger<ProfitechReadyHandler> _logger;
        public ProfitechReadyHandler(IHaContext context, ILogger<ProfitechReadyHandler> logger)
        {
            _entities = new Entities(context);
            _logger = logger;
        }

        public Task Handle(ProfitecCurrentMeasurementChanged notification, CancellationToken cancellationToken)
        {
            if (notification.OldPowerConsumption > 950000 && notification.CurrentPowerConsumption < 950000)
            {
                _entities.InputBoolean.Profitecready.TurnOn();
                _logger.LogDebug($"Espresso machine is ready!");
            }
            return Task.CompletedTask;
        }
    }
}
