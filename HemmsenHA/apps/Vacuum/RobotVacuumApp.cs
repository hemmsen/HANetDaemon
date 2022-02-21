namespace HemmsenHA.apps.Vacuum
{
    [NetDaemonApp]
    public class RobotVacuumApp
    {
        public RobotVacuumApp(INetDaemonScheduler scheduler, IMediator mediator, IHaContext haContext, ILogger<RobotVacuumApp> logger)
        {
            try
            {
                var entities = new Entities(haContext);
                var services = new Services(haContext);
                var dailyVacumStartAt = TimeSpan.Parse(entities.InputDatetime.Dailyvacuumcleanstartat.State);
                entities.Vacuum.RoborockS6Maxv
                     .StateChanges()
                     .Where(x => x.New.Attributes.Status == "Charging")
                     .Subscribe(x =>
                     {
                         if(DateTime.Now.Hour < 7)
                         {
                             services.Light.TurnOff(ServiceTarget.FromEntity(entities.Light.LivingroomLights.EntityId));
                             services.Light.TurnOff(ServiceTarget.FromEntity(entities.Light.KokkenSpotsLevelOnOff.EntityId));
                         }
                     });

                scheduler.RunDaily(dailyVacumStartAt, () =>
                {
                    //Trigger clean in livingroom and kitchen
                    //16 segment is livingroom, 17 is kitchen
                    mediator.Publish(new VacuumClean() { TriggederAt = DateTime.Now, Segments = new int[] { 16, 17 } });
                });

                scheduler.RunDaily(new TimeSpan(6, 0, 0), () =>
                {
                    // use this command to go to trash bin for empty
                    if (entities.Counter.Dustbinemptycreditsleft.State == "0")
                    {
                        services.XiaomiMiio.VacuumGoto(ServiceTarget.FromEntity(entities.Vacuum.RoborockS6Maxv.EntityId), "21500", "25500");
                        services.Counter.Reset(ServiceTarget.FromEntity(entities.Counter.Dustbinemptycreditsleft.EntityId));
                    }
                });
            }catch (Exception ex)
            {
                logger.LogCritical(ex, "Error starting {AppName}", nameof(RobotVacuumApp));
            }
           
        }
    }
}
