namespace HemmsenHA.apps.CarbonDioxideChangedApp;
public class CarbonDioxideChangedBedroom
{
    public CarbonDioxideChangedBedroom(IEntities entities, IMediator mediator)
    {
        entities.Sensor.NetatmoEngelstoft157IndoorSovevaerelseCo2
            .StateAllChanges()
            .Subscribe(entity =>
            {
                var carbonDioxideChanged = new CarbonDioxideChanged()
                {
                    EntityId = entity.Entity.EntityId,
                    NewEntityState = entity.New,
                    OldEntityState = entity.Old
                };
                mediator.Publish(carbonDioxideChanged);
            });
    }
}