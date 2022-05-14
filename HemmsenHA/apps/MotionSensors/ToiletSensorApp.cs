namespace HemmsenHA.apps.MotionsSensors;
[NetDaemonApp]
[Focus]
public class ToiletMotionSensorApp
{
    public ToiletMotionSensorApp(IEntities entities, IMediator mediator, ILogger<ToiletMotionSensorApp> logger, IOptionsMonitor<HaConfigOptions> optionsMonitor)
    {
        entities.BinarySensor.MotionToiletIasZone2
           .StateAllChanges()
           .Where(x => x.New.State == "on")
           .Subscribe(async x =>
           {
               var motionNotification = new MotionSensorStateActive()
               {
                   EntityId = x.Entity.EntityId,
                   LightEntityId = entities.Light.ToiletOnOff.EntityId,
                   NewEntityState = x.New,
                   OldEntityState = x.Old
               };
               logger.LogInformation("Turn on light notification in Toilet");
               await mediator.Publish(motionNotification);
           });

        entities.BinarySensor.MotionToiletIasZone2
            .StateAllChanges()
            .WhenStateIsFor(x => x.State == "off", TimeSpan.FromMinutes(optionsMonitor.CurrentValue.ThrottleDelayinMinutesMotionCleared))
            .Subscribe(async x =>
            {
                var motionNotification = new MotionSensorCleared()
                {
                    EntityId = x.Entity.EntityId,
                    LightEntityId = entities.Light.ToiletOnOff.EntityId,
                    NewEntityState = x.New,
                    OldEntityState = x.Old
                };
                logger.LogInformation("Turn off light notification in Toilet");
                await mediator.Publish(motionNotification);
            });
    }
}