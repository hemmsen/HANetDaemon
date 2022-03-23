namespace HemmsenHA.apps.Eva;
[NetDaemonApp]
public class EvaLightApp
{
    public EvaLightApp(IEntities entities, IMediator mediator)
    {
        entities.Light.EvaLysLevelLightColorOnOff
        .StateChanges()
        .Subscribe(x =>
        {
            var notification = new LightStateChanged()
            {
                EntityId = x.Entity.EntityId,
                NewEntityState = x.New,
                OldEntityState = x.Old
            };
            mediator.Publish(notification);
        });
    }
}