namespace HemmsenHA.Infrastructure.Strategies;
public class LowTempBedroomLateNightStrategy : ITemperatureChangedStrategy
{
    private readonly IEntities entities;
    private readonly ILogger<LowTempBedroomLateNightStrategy> logger;
    private readonly IMediator mediator;
    private readonly IHaContext haContext;
    private readonly HaConfigOptions haConfigOptions;
    public LowTempBedroomLateNightStrategy(IEntities entities, ILogger<LowTempBedroomLateNightStrategy> logger, IMediator mediator, IHaContext haContext, IOptionsSnapshot<HaConfigOptions> options)
    {
        this.entities = entities;
        this.logger = logger;
        this.mediator = mediator;
        this.haContext = haContext;
        haConfigOptions = options.Value;
    }
    public bool CanHandle(ClimateChangedNotification temperatureChangedNotification)
    {
        return
        // Check if EntityId equals climate entity in bedroom
        temperatureChangedNotification.EntityId == entities.Climate.BedroomThermostatThermostat.EntityId
        // Check if current temperature is under threshold
        // TODO get threshold from helper in HA
        && temperatureChangedNotification?.NewEntityState?.Attributes?.CurrentTemperature < haConfigOptions.LowTempAlarmBedroom
        //Check that measured at is not night time
        && temperatureChangedNotification.MeasuredAt.TimeOfDay > haConfigOptions.MuteTemperatureNotificationsAfter
        // Window is open in bedroom
        && entities.BinarySensor.BedroomWindow.IsOn();
    }

    public void DoAction(ClimateChangedNotification climateChangedNotification)
    {
        if (entities.Light.LivingroomLights.IsOn())
        {
            // Say it in livingroom over Sonos speakers
            var speakerNotification = new SpeakerNotification()
            {
                EntityId = entities.MediaPlayer.TvStue.EntityId,
                NotificationMessage = $"Temperatur i {new Entity(haContext, climateChangedNotification.EntityId).Area} er {climateChangedNotification?.NewEntityState?.Attributes?.CurrentTemperature} grader. Luk vinduet!"
            };
            mediator.Publish(speakerNotification);
        }
    }
}
