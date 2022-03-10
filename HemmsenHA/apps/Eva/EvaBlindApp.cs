namespace HemmsenHA.apps.Eva
{
    [NetDaemonApp]
    public class EvaBlindApp
    {
        public EvaBlindApp(IHaContext haContext, INetDaemonScheduler scheduler, IMediator mediator, ILogger<EvaBlindApp> logger)
        {
            try
            {
                var entities = new Entities(haContext);
                var services = new Services(haContext);
                //Open blinds at Evas room
                scheduler.RunDaily(new TimeSpan(9, 0, 0), () =>
                {
                    mediator.Publish(new BlindsStateChange() { EntityId = entities.Number.EvaBlindsPercentageOpen.EntityId, PercentageOpen = 100 });
                });

                entities.Number.EvaBlindsPercentageOpen
                    .StateAllChanges()
                    .Throttle(TimeSpan.FromMinutes(2))
                    .Subscribe(x =>
                    {
                        var percentageOpen = x?.New?.State != null ? x?.New?.State.Value : throw new ArgumentNullException("New state are null for entityId: {EntityId}", x?.Entity.EntityId);
                        mediator.Publish(new BlindsStateChange() { EntityId = entities.Number.EvaBlindsPercentageOpen.EntityId, PercentageOpen = Convert.ToInt32(percentageOpen) });

                    });

                entities.InputBoolean.Evablindsclosed
                    .StateAllChanges()
                    .Subscribe(x =>
                    {
                        if (x.New.IsOff())
                        {
                            mediator.Publish(new BlindsStateChange() { EntityId = entities.Number.EvaBlindsPercentageOpen.EntityId, PercentageOpen = 100 });
                        }
                        if (x.New.IsOn())
                        {
                            mediator.Publish(new BlindsStateChange() { EntityId = entities.Number.EvaBlindsPercentageOpen.EntityId, PercentageOpen = 0 });
                        }
                    });
            }catch (Exception ex)
            {
                logger.LogCritical(ex,"Error starting {AppName}", nameof(EvaBlindApp));
            }
            
        }
    }
}
