namespace HemmsenHA.apps.Bedroom
{
    [NetDaemonApp]
    [Focus]
    public class BedroomWindowSensorApp
    {
        public BedroomWindowSensorApp(IHaContext haContext, IMediator mediator, ILogger<BedroomWindowSensorApp> logger)
        {
            try
            {
                var _entities = new Entities(haContext);
                _entities.BinarySensor.BedroomWindow
                    .StateAllChanges()
                    .Subscribe(x =>
                    {
                        var stateChanged = new WindowStateChanged()
                        {
                            EntityId = x.New.EntityId,
                            NewState = x.New,
                            OldState = x.Old,
                        };
                        mediator.Publish(stateChanged);
                    });
            }catch (Exception ex)
            {
                logger.LogCritical(ex,"Error starting {AppName}", nameof(BedroomWindowSensorApp));
            }
            
        }
    }
}
