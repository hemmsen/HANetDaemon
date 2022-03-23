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
        && DateTimeOffset.Now.TimeOfDay > TimeSpan.FromHours(18.5)
        && DateTimeOffset.Now.TimeOfDay < TimeSpan.FromHours(19.5);
    }

    public Task DoAction(LightStateChanged lightStateChanged)
    {
        _services.MediaPlayer.PlayMedia(ServiceTarget.FromEntity(_entities.MediaPlayer.Sovevaerelse.EntityId), @"x-sonos-spotify:spotify%3atrack%3a0tUbZj0kg8zXSHLtwnovuB?sid=9&flags=8224&sn=1", "music");
        return Task.CompletedTask;
    }
}
