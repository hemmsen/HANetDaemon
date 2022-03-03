namespace HemmsenHA.apps
{
    [NetDaemonApp]
    //[Focus]
    public class CarbonDioxideChangedApp
    {
        public CarbonDioxideChangedApp(IHaContext haContext, ILogger<CarbonDioxideChangedApp> logger, IMediator mediator)
        {
            var entities = new Entities(haContext);
            var services = new Services(haContext);
            try
            {
                entities.Sensor.NetatmoEngelstoft157IndoorCo2
                    .StateAllChanges()
                    .Subscribe(s =>
                    {
                        var carbonDioxideChanged = new CarbonDioxideChanged()
                        {
                            EntityId = s.Entity.EntityId,
                            NewEntityState = s.New,
                            OldEntityState = s.Old
                        };
                        mediator.Publish(carbonDioxideChanged);
                    });
            }
            catch (Exception ex)
            {
                logger.LogCritical(ex, "Error starting {AppName}", nameof(CarbonDioxideChangedApp));
            }
        }
    }
}
