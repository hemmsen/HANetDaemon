namespace HemmsenHA.apps.Eva
{
    [NetDaemonApp]
    public class EvaWindowSensorApp
    {
        public EvaWindowSensorApp(IHaContext haContext, IMediator mediator, ILogger<EvaWindowSensorApp> logger)
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
            }
            catch (Exception ex)
            {
                logger.LogCritical(ex, "Error starting {AppName}", nameof(EvaWindowSensorApp));
            }

        }
    }
}
