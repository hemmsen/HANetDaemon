namespace HemmsenHA.Infrastructure.NotificationHandlers
{
    public class WindowStateChangedHandler : NotificationHandler<WindowStateChanged>
    {
        private IEnumerable<IWindowStateChangedStrategy> strategies;
        private ILogger<WindowStateChangedHandler> logger;

        public WindowStateChangedHandler(IEnumerable<IWindowStateChangedStrategy> strategies, ILogger<WindowStateChangedHandler> logger)
        {
            this.strategies = strategies;
            this.logger = logger;
        }
        protected override void Handle(WindowStateChanged notification)
        {
            var strategy = strategies.SingleOrDefault(x => x.CanHandle(notification));

            if (strategy != null)
            {
                strategy.DoAction(notification);
            }
            else
            {
                logger.LogError("Can't find strategy for {InterfaceStrategyName}!", nameof(IWindowStateChangedStrategy));
            }
        }
    }
}
