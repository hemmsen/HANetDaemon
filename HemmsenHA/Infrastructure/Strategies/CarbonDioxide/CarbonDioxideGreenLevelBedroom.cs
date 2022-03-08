namespace HemmsenHA.Infrastructure.Strategies;
public class CarbonDioxideYellowLevelBedroomStrategy : ICarbonDioxideChangedStrategy
{
    private readonly IEntities entities;
    private readonly IMediator mediator;
    private readonly HaConfigOptions haConfigOptions;
    public CarbonDioxideYellowLevelBedroomStrategy(IEntities entities, IMediator mediator, IOptionsSnapshot<HaConfigOptions> options)
    {
        this.entities = entities;
        this.mediator = mediator;
        this.haConfigOptions = options.Value;
    }
    public bool CanHandle(CarbonDioxideChanged carbonDioxideChanged)
    {
        return carbonDioxideChanged.EntityId == entities.Sensor.NetatmoEngelstoft157IndoorSovevaerelseCo2.EntityId && carbonDioxideChanged.NewEntityState.State > haConfigOptions.CO2GreenHigh
        && carbonDioxideChanged.MeasuredAt.TimeOfDay < haConfigOptions.MuteTemperatureNotificationsAfter
        && carbonDioxideChanged.MeasuredAt.TimeOfDay > haConfigOptions.TurnOnNotificationsAfter;
    }

    public Task DoAction(CarbonDioxideChanged carbonDioxideChanged)
    {
        var notification = new SpeakerNotification()
        {
            EntityId = entities.MediaPlayer.TvStue.EntityId,
            NotificationMessage = $"Der trænger til at blive luftet ud i {entities.Climate.BedroomThermostatThermostat.Area}. Co2 niveau er for højt!"
        };
        mediator.Publish(notification);
        return Task.CompletedTask;
    }
}