namespace HemmsenHA.Infrastructure.Strategies;
public class LowTemperatureBedroomStrategy : ITemperatureChangedStrategy
{
    private readonly IEntities _entities;
    private readonly IMediator _mediator;

    public LowTemperatureBedroomStrategy(IEntities entities, IMediator mediator)
    {
        _entities = entities;
        _mediator = mediator;
    }
    public bool CanHandle(ClimateChangedNotification temperatureChangedNotification)
    {
        return
        // Check if EntityId equals climate entity in bedroom
        temperatureChangedNotification.EntityId == _entities.Climate.BedroomThermostatThermostat.EntityId
        // Check if current temperature is under threshold
        // TODO get threshold from helper in HA
        && temperatureChangedNotification?.NewEntityState?.Attributes?.CurrentTemperature < 17
        //Check that measured at is not night time
        && temperatureChangedNotification.MeasuredAt.TimeOfDay < new TimeSpan(22, 0, 0)
        // Window is open in bedroom
        && _entities.BinarySensor.BedroomWindow.IsOn();
    }

    public void DoAction(ClimateChangedNotification temperatureChangedNotification)
    {
        SonosSpeakerNotification(temperatureChangedNotification);
        AppPushNotification(temperatureChangedNotification);
    }


    private void AppPushNotification(ClimateChangedNotification climateChangedNotification)
    {
        var notification = new CloseWindowInRoomNotification()
        {
            CurrentTemperature = climateChangedNotification?.NewEntityState?.Attributes?.CurrentTemperature,
            EntityId = climateChangedNotification?.EntityId ?? throw new ArgumentException("EntityId cannot be null")
        };
        _mediator.Publish(notification);
    }

    private void SonosSpeakerNotification(ClimateChangedNotification climateChangedNotification)
    {
        // Say it in livingroom over Sonos speakers
        var speakerNotification = new SpeakerNotification()
        {
            EntityId = _entities.MediaPlayer.TvStue.EntityId,
            NotificationMessage = $"Temperatur i {_entities.MediaPlayer.TvStue.Area} er {climateChangedNotification.NewEntityState.Attributes.CurrentTemperature} grader. Luk vinduet!"
        };
        _mediator.Publish(speakerNotification);
    }


}