namespace HemmsenHA.Infrastructure.Strategies;
public class LowTemperatureEvaStrategy : ITemperatureChangedStrategy
{
    private readonly IEntities entities;
    private readonly IMediator mediator;
    public LowTemperatureEvaStrategy(IEntities entities, IMediator mediator)
    {
        this.entities = entities;
        this.mediator = mediator;
    }

    public bool CanHandle(ClimateChangedNotification temperatureChangedNotification)
    {
        return
        // Check if entityId mathces Eva's room
        temperatureChangedNotification.EntityId == entities.Climate.NetatmoEva.EntityId
        // Check if current temperature is under threshold
        && temperatureChangedNotification.NewEntityState.Attributes.CurrentTemperature < 17
        // Check if window is open
        && entities.BinarySensor.LumiLumiSensorMagnetAq261992507OnOff.IsOn();
    }

    public void DoAction(ClimateChangedNotification temperatureChangedNotification)
    {
        var SpeakerNotification = new SpeakerNotification()
        {
            EntityId = entities.MediaPlayer.TvStue.EntityId,
            NotificationMessage = $"Lav temperatur i {entities.Climate.NetatmoEva.Area}. Luk vinduet!"
        };
        mediator.Publish(SpeakerNotification);
    }
}