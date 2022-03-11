namespace HemmsenHA.apps.Eva
{
    [NetDaemonApp]
    public class EvaBlindApp
    {
        public EvaBlindApp(IEntities entities, IServices services, INetDaemonScheduler scheduler, IMediator mediator, ILogger<EvaBlindApp> logger)
        {
            try
            {
                scheduler.RunDaily(new TimeSpan(9, 0, 0), () =>
                {
                    mediator.Publish(new BlindsStateChange() { EntityId = entities.Number.EvaBlindsPercentageOpen.EntityId, BlindState = BlindState.Open });
                });

                entities.InputBoolean.Evablindsclosed
                    .StateAllChanges()
                    .Subscribe(x =>
                    {
                        if (x.New.IsOff())
                        {
                            mediator.Publish(new BlindsStateChange() { EntityId = entities.Number.EvaBlindsPercentageOpen.EntityId, BlindState = BlindState.Open });
                        }
                        if (x.New.IsOn())
                        {
                            mediator.Publish(new BlindsStateChange() { EntityId = entities.Number.EvaBlindsPercentageOpen.EntityId, BlindState = BlindState.Closed });
                        }
                    });
            }
            catch (Exception ex)
            {
                logger.LogCritical(ex, "Error starting {AppName}", nameof(EvaBlindApp));
            }

        }
    }
}
