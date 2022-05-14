namespace daemonapp.Handlers
{
    public class BlindsStateChangeHandler : INotificationHandler<BlindsStateChange>
    {
        private IServices services;
        private IEntities entities;
        private readonly IHaContext haContext;

        public BlindsStateChangeHandler(IHaContext haContext, IEntities entities, IServices services)
        {
            this.services = services;
            this.entities = entities;
            this.haContext = haContext;
        }

        public Task Handle(BlindsStateChange notification, CancellationToken cancellationToken)
        {
            switch (notification.BlindState)
            {
                case BlindState.Open:
                    services.Number.SetValue(ServiceTarget.FromEntity(entities.Number.EvaBlindsPercentageOpen.EntityId), "100");
                    services.Logbook.Log(nameof(BlindsStateChangeHandler), $"Did open blind for area {new Entity(haContext, notification.EntityId)}", notification.EntityId);
                    entities.InputBoolean.Evablindsclosed.TurnOff();
                    return Task.CompletedTask;
                case BlindState.Closed:
                    services.Number.SetValue(ServiceTarget.FromEntity(entities.Number.EvaBlindsPercentageOpen.EntityId), "0");
                    entities.InputBoolean.Evablindsclosed.TurnOn();
                    services.Logbook.Log(nameof(BlindsStateChangeHandler), $"Did open blind for area {new Entity(haContext, notification.EntityId)}", notification.EntityId);
                    return Task.CompletedTask;
            }
            return Task.FromException(new ArgumentException());
        }
    }
}
