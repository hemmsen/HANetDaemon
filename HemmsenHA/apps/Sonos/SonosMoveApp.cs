namespace HemmsenHA.apps.Sonos
{
    [NetDaemonApp]
    public class SonosMoveApp
    {
        public SonosMoveApp(IHaContext haContext, IMediator mediator)
        {
            var entities = new Entities(haContext);

            entities.Sensor.MoveBattery
                .StateAllChanges()
                .Where(state => state?.New?.State < 20)
                .Subscribe(state =>
                {
                    var lowBatteryAlert = new LowPowerOnDevice()
                    {
                        EntityId = state.Entity.EntityId,
                        PowerLevel = state?.New?.State
                    };

                    mediator.Publish(lowBatteryAlert);
                });
        }
    }
}
