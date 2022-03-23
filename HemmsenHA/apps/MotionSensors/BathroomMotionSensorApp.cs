namespace HemmsenHA.apps.MotionsSensors;
[NetDaemonApp]
public class BathroomMotionSensorApp
{
    public BathroomMotionSensorApp(IEntities entities, IMediator mediator)
    {
        entities.BinarySensor.MotionBathroomIasZone
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

        entities.BinarySensor.MotionBathroomIasZone
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