namespace HemmsenHA.apps.TemperatureChangedApp;
public class EvaRoomTemperatureChangedApp
{
    public EvaRoomTemperatureChangedApp(IEntities entities, IMediator mediator)
    {
        entities.Climate.NetatmoEva
            .StateAllChanges()
            .Subscribe(entity =>
            {
                var notification = new ClimateChangedNotification()
                {
                    EntityId = entity.Entity.EntityId,
                    NewEntityState = entity.New,
                    OldEntityState = entity.Old
                };
                mediator.Publish(notification);
            });
    }
}