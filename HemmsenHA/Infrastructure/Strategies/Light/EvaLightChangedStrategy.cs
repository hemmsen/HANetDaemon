namespace HemmsenHA.Infrastructure.Strategies.Light;
public class EvaLightChangedStrategy : ILightStateChangedStrategy
{
    private readonly IEntities _entities;
    private readonly IServices _services;

    public EvaLightChangedStrategy(IEntities entities, IServices services)
    {
        _entities = entities;
        _services = services;
    }
    public bool CanHandle(LightStateChanged lightStateChanged)
    {
        return _entities.Light.EvaLysLevelLightColorOnOff.EntityId == lightStateChanged.EntityId
        && lightStateChanged.NewEntityState.IsOff()
        && _entities.Number.EvaBlindsPercentageOpen.State < 50;
    }

    public Task DoAction(LightStateChanged lightStateChanged)
    {
        _services.MediaPlayer.PlayMedia(ServiceTarget.FromEntity(_entities.MediaPlayer.Sovevaerelse.EntityId), @"spotify:playlist:21wbvqMl5HNxhfi2cNqsdZ", "music");
        _services.Light.TurnOn(ServiceTarget.FromEntity(_entities.Light.EvaSengLevelLightColorOnOff.EntityId), rgbwColor: new int[] { 255, 0, 0, 0 }, brightnessPct: 33);
        return Task.CompletedTask;
    }
}
