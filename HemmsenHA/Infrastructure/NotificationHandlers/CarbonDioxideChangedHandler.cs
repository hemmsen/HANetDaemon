namespace HemmsenHA.Infrastructure.NotificationHandlers
{
    public class CarbonDioxideChangedHandler : INotificationHandler<CarbonDioxideChanged>
    {
        private IEnumerable<ICarbonDioxideChangedStrategy> strategies;
        private readonly ILogger<CarbonDioxideChangedHandler> logger;
        public CarbonDioxideChangedHandler(IEnumerable<ICarbonDioxideChangedStrategy> strategies, ILogger<CarbonDioxideChangedHandler> logger)
        {
            this.strategies = strategies;
            this.logger = logger;
        }

        public Task Handle(CarbonDioxideChanged notification, CancellationToken cancellationToken)
        {
            var strategy = strategies.FirstOrDefault(x => x.CanHandle(notification));
            if(strategy == null)
            {
                logger.LogError("Can't find strategy for {InterfaceStrategyName}", nameof(ICarbonDioxideChangedStrategy));
                return Task.CompletedTask;
            }
            strategy.DoAction(notification);
            return Task.CompletedTask;
        }
    }
}
