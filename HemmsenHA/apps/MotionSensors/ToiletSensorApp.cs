namespace HemmsenHA.apps.MotionsSensors;
[NetDaemonApp]
public class ToiletMotionSensorApp
{
    public ToiletMotionSensorApp(IEntities entities, IMediator mediator)
    {
        entities.BinarySensor.MotionToiletIasZone
           .StateAllChanges()
           .Where(x => x.New.State == "on")
           .Subscribe(async x =>
           {
               var motionNotification = new MotionSensorStateActive()
               {
                   EntityId = x.Entity.EntityId,
                   NewEntityState = x.New,
                   OldEntityState = x.Old
               };
               await mediator.Publish(motionNotification);
           });

        entities.BinarySensor.MotionToiletIasZone
            .StateAllChanges()
            .Where(x => x.New.State == "off")
            .Throttle(TimeSpan.FromMinutes(3))
            .Subscribe(async x =>
            {
                var motionNotification = new MotionSensorCleared()
                {
                    EntityId = x.Entity.EntityId,
                    NewEntityState = x.New,
                    OldEntityState = x.Old
                };
                await mediator.Publish(motionNotification);
            });
    }
}