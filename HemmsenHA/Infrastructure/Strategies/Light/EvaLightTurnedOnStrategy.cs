namespace HemmsenHA.Infrastructure.Strategies.Light;
public class EvaLightTurnedOnStrategy : ILightStateChangedStrategy
{
    private readonly IEntities _entities;
    private readonly IServices _services;

    public EvaLightTurnedOnStrategy(IEntities entities, IServices services)
    {
        _entities = entities;
        _services = services;
    }
    public bool CanHandle(LightStateChanged lightStateChanged)
    {
        return _entities.Light.EvaLysLevelLightColorOnOff.EntityId == lightStateChanged.EntityId
        && lightStateChanged.NewEntityState.IsOn();
    }

    public Task DoAction(LightStateChanged lightStateChanged)
    {
        _services.MediaPlayer.MediaStop(ServiceTarget.FromEntity(_entities.MediaPlayer.Sovevaerelse.EntityId));
        _services.Light.TurnOff(ServiceTarget.FromEntity(_entities.Light.EvaSengLevelLightColorOnOff.EntityId));
        return Task.CompletedTask;
    }
}
