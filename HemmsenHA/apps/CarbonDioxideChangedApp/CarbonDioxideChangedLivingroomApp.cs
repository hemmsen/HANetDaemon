namespace HemmsenHA.apps
{
    [NetDaemonApp]
    //[Focus]
    public class CarbonDioxideChangedLivingroomApp
    {
        public CarbonDioxideChangedLivingroomApp(IEntities entities, IServices services, ILogger<CarbonDioxideChangedLivingroomApp> logger, IMediator mediator)
        {
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
