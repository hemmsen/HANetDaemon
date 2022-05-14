namespace HemmsenHA.apps.TemperatureChangedApp;
[NetDaemonApp]
public class EvaRoomTemperatureChangedApp
{
    public EvaRoomTemperatureChangedApp(IEntities entities, IMediator mediator, ILogger<EvaRoomTemperatureChangedApp> logger)
    {
        entities.Climate.NetatmoEva
            .StateAllChanges()
            .Subscribe(async entity =>
            {
                logger.LogInformation($"Climate state changed for Eva - Old current tempearture: {entity?.Old?.Attributes?.CurrentTemperature} and new current temperature: {entity?.New?.Attributes?.CurrentTemperature}");
                var notification = new ClimateChangedNotification()
                {
                    EntityId = entity.Entity.EntityId,
                    NewEntityState = entity.New,
                    OldEntityState = entity.Old
                };
                await mediator.Publish(notification);
            });
    }
}