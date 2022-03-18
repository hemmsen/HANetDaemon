namespace HemmsenHA.apps.CarbonDioxideChangedApp;
public class CarbonDioxideChangedBedroom
{
    public CarbonDioxideChangedBedroom(IEntities entities, IMediator mediator, IOptionsMonitor<HaConfigOptions> optionsMonitor)
    {
        entities.Sensor.NetatmoEngelstoft157IndoorSovevaerelseCo2
            .StateAllChanges()
            .Where(x =>
            {
                var CurrentValue = optionsMonitor.CurrentValue;
                // Only make this notification if this is not to late
                return DateTimeOffset.Now.TimeOfDay < CurrentValue.MuteTemperatureNotificationsAfter;
            })
            .Subscribe(async entity =>
            {
                var carbonDioxideChanged = new CarbonDioxideChanged()
                {
                    EntityId = entity.Entity.EntityId,
                    NewEntityState = entity.New,
                    OldEntityState = entity.Old
                };
                await mediator.Publish(carbonDioxideChanged);
            });
    }
}