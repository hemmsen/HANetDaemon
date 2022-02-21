using System;
using System.Collections.Generic;
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
                    mediator.Publish(new BlindsStateChange() { EntityId = entities.Number.EvaBlindPercentageOpen.EntityId, PercentageOpen = 100 });
                });

                entities.Number.EvaBlindPercentageOpen
                    .StateAllChanges()
                    .Throttle(TimeSpan.FromMinutes(2))
                    .Subscribe(x =>
                    {
                        mediator.Publish(new BlindsStateChange() { EntityId = entities.Number.EvaBlindPercentageOpen.EntityId, PercentageOpen = Convert.ToInt32(x.New.State.Value) });

                    });

                entities.InputBoolean.Evablindsclosed
                    .StateAllChanges()
                    .Subscribe(x =>
                    {
                        if (x.New.IsOff())
                        {
                            mediator.Publish(new BlindsStateChange() { EntityId = entities.Number.EvaBlindPercentageOpen.EntityId, PercentageOpen = 100 });
                        }
                        if (x.New.IsOn())
                        {
                            mediator.Publish(new BlindsStateChange() { EntityId = entities.Number.EvaBlindPercentageOpen.EntityId, PercentageOpen = 0 });
                        }
                    });
            }catch (Exception ex)
            {
                logger.LogCritical(ex,"Error starting {AppName}", nameof(EvaBlindApp));
            }
            
        }
    }
}
