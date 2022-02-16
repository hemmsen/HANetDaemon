namespace daemonapp.Handlers
{
    public class BlindsStateChangeHandler : INotificationHandler<BlindsStateChange>
    {
        private IServices services;
        private IEntities entities;

        public BlindsStateChangeHandler(IHaContext haContext)
        {
            services = new Services(haContext);
            entities = new Entities(haContext); 
        }

        public Task Handle(BlindsStateChange notification, CancellationToken cancellationToken)
        {
            if (notification.PercentageOpen == 100)
            {
                services.InputBoolean.TurnOff(ServiceTarget.FromEntity(entities.InputBoolean.Evablindsclosed.EntityId));
            }
            if(notification.PercentageOpen == 0)
            {
                services.InputBoolean.TurnOn(ServiceTarget.FromEntity(entities.InputBoolean.Evablindsclosed.EntityId));
            }
            services.Number.SetValue(ServiceTarget.FromEntity(notification.EntityId), notification.PercentageOpen.ToString());
            services.Logbook.Log(nameof(BlindsStateChangeHandler), $"Changed blinds settings for entity to {notification.PercentageOpen}", notification.EntityId);
            return Task.CompletedTask;
        }
    }
}
