namespace HemmsenHA.Infrastructure.NotificationHandlers
{
    public class CarbonDioxideChangedHandler : INotificationHandler<CarbonDioxideChanged>
    {
        private IEnumerable<ICarbonDioxideChangedStrategy> strategies;
        private readonly ILogger<CarbonDioxideChangedHandler> logger;
        private readonly HaConfigOptions haConfigOptions;

        public CarbonDioxideChangedHandler(IEnumerable<ICarbonDioxideChangedStrategy> strategies, ILogger<CarbonDioxideChangedHandler> logger, IOptionsSnapshot<HaConfigOptions> optionsSnapshot)
        {
            this.strategies = strategies;
            this.logger = logger;
            haConfigOptions = optionsSnapshot.Value;
        }

        public async Task Handle(CarbonDioxideChanged notification, CancellationToken cancellationToken)
        {
            var strategy = strategies.FirstOrDefault(x => x.CanHandle(notification));
            if (strategy == null)
            {
                logger.LogError("Can't find strategy for {InterfaceStrategyName}, new co2 level = {co2level}, EntityId:{EntityId}", nameof(ICarbonDioxideChangedStrategy), notification?.NewEntityState?.State, notification?.EntityId);
                return;
            }
            logger.LogInformation("Found carbon dioxide strategy for entityId: {entityId} and current co2 measurement {co2level}", notification.EntityId, notification?.NewEntityState?.State);
            await strategy.DoAction(notification);
            return;
        }
    }
}
