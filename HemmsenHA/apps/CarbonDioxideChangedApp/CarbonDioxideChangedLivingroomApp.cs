namespace HemmsenHA.apps
{
    [NetDaemonApp]
    //[Focus]
    public class CarbonDioxideChangedLivingroomApp
    {
        public CarbonDioxideChangedLivingroomApp(IEntities entities, IServices services, ILogger<CarbonDioxideChangedLivingroomApp> logger, IMediator mediator, IOptionsMonitor<HaConfigOptions> optionsMonitor)
        {
            try
            {
                entities.Sensor.NetatmoEngelstoft157IndoorCo2
                    .StateAllChanges()
                    .Where(x =>
                    {
                        var CurrentValue = optionsMonitor.CurrentValue;
                        // Only make this notification if this is not to late
                        return DateTimeOffset.Now.TimeOfDay < CurrentValue.MuteTemperatureNotificationsAfter;
                    })
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
