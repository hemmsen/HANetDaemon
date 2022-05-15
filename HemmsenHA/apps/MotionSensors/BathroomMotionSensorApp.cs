namespace HemmsenHA.apps.MotionsSensors;
[NetDaemonApp]
[Focus]
public class BathroomMotionSensorApp
{
    public BathroomMotionSensorApp(IEntities entities, IMediator mediator, IOptionsMonitor<HaConfigOptions> optionsMonitor)
    {
        entities.BinarySensor.MotionBathroomIasZone
            .StateAllChanges()
            .Where(x => x.New?.State == "on")
            .Subscribe(async x =>
            {
                var motionNotification = new MotionSensorStateActive()
                {
                    EntityId = x.Entity.EntityId,
                    LightEntityId = entities.Light.BathroomSpotsLevelOnOff.EntityId,
                    NewEntityState = x.New,
                    OldEntityState = x.Old
                };
                await mediator.Publish(motionNotification);
            });

        entities.BinarySensor.MotionBathroomIasZone
            .StateAllChanges()
            .WhenStateIsFor(x => x.State == "off", TimeSpan.FromMinutes(optionsMonitor.CurrentValue.ThrottleDelayinMinutesMotionCleared))
            .Subscribe(async x =>
            {
                var motionNotification = new MotionSensorCleared()
                {
                    EntityId = x.Entity.EntityId,
                    LightEntityId = entities.Light.BathroomSpotsLevelOnOff.EntityId,
                    NewEntityState = x.New,
                    OldEntityState = x.Old
                };
                await mediator.Publish(motionNotification);
            });
    }
}