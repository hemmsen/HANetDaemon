namespace HemmsenHA.Infrastructure.Strategies;
public class HighTempBedroomStrategy : ITemperatureChangedStrategy
{
    private readonly IEntities entities;
    private readonly IMediator mediator;
    private readonly IHaContext haContext;
    private readonly HaConfigOptions haConfigOptions;

    public HighTempBedroomStrategy(IEntities entities, IMediator mediator, IHaContext haContext, IOptionsSnapshot<HaConfigOptions> optionsSnapshot)
    {
        this.entities = entities;
        this.mediator = mediator;
        this.haContext = haContext;
        this.haConfigOptions = optionsSnapshot.Value;
    }

    public bool CanHandle(ClimateChangedNotification climateChangedNotification)
    {
        return climateChangedNotification.EntityId == entities.Climate.BedroomThermostatThermostat.EntityId
               && climateChangedNotification?.NewEntityState?.Attributes?.CurrentTemperature >= haConfigOptions.HighTempAlarmBedroom
               && entities.BinarySensor.BedroomWindow.IsOff();
    }

    public void DoAction(ClimateChangedNotification climateChangedNotification)
    {
        var notification = new SpeakerNotification()
        {
            EntityId = entities.MediaPlayer.TvStue.EntityId,
            NotificationMessage = $"Der trænger til at blive luftet ud i {new Entity(haContext, climateChangedNotification.EntityId).Area}"
        };
        mediator.Publish(notification);
    }
}