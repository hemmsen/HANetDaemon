namespace HemmsenHA.Infrastructure.Strategies;
public class DecreaseTemperatureEvaStrategy : ITemperatureChangedStrategy
{
    private readonly IEntities entities;
    private readonly IMediator mediator;
    private readonly HaConfigOptions haConfigOptions;
    public DecreaseTemperatureEvaStrategy(IEntities entities, IMediator mediator, IOptionsSnapshot<HaConfigOptions> options)
    {
        this.entities = entities;
        this.mediator = mediator;
        haConfigOptions = options.Value;
    }

    public bool CanHandle(ClimateChangedNotification temperatureChangedNotification)
    {
        return
        // Check if entityId mathces Eva's room
        temperatureChangedNotification.EntityId == entities.Climate.NetatmoEva.EntityId
        // Check if current temperature is under threshold
        && temperatureChangedNotification?.NewEntityState?.Attributes?.CurrentTemperature > 19
        // Check if window is open
        && entities.BinarySensor.LumiLumiSensorMagnetAq261992507OnOff.IsOff()
        // Check if time of day is after threshold
        && DateTimeOffset.Now.TimeOfDay > TimeSpan.FromHours(17)
        && DateTimeOffset.Now.TimeOfDay < TimeSpan.FromHours(19);
    }

    public void DoAction(ClimateChangedNotification temperatureChangedNotification)
    {
        var SpeakerNotification = new SpeakerNotification()
        {
            EntityId = entities.MediaPlayer.TvStue.EntityId,
            NotificationMessage = $"Husk at åben vinduet på Evas værelse"
        };
        mediator.Publish(SpeakerNotification);
    }
}