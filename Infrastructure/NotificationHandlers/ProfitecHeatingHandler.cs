namespace daemonapp.Handlers
{
    public class ProfitecHeatingHandler : INotificationHandler<ProfitecHeatingMessage>
    {
        private readonly Entities _entities;
        private readonly Services _services;

        public ProfitecHeatingHandler(IHaContext haContext)
        {
            _entities = new Entities(haContext);
            _services = new Services(haContext);
        }

        public Task Handle(ProfitecHeatingMessage notification, CancellationToken cancellationToken)
        {
            _services.InputBoolean.TurnOff(ServiceTarget.FromEntity(_entities.InputBoolean.Profitecready.EntityId));
            return Task.CompletedTask;
        }
    }
}
