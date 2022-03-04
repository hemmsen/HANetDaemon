namespace HemmsenHA.Infrastructure.Strategies;
public class CarbonDioxideGreenLevelBedroomStrategy : ICarbonDioxideChangedStrategy
{
    private readonly IEntities entities;
    private readonly IMediator mediator;
    public CarbonDioxideGreenLevelBedroomStrategy(IEntities entities, IMediator mediator)
    {
        this.entities = entities;
        this.mediator = mediator;
    }
    public bool CanHandle(CarbonDioxideChanged carbonDioxideChanged)
    {
        return carbonDioxideChanged.EntityId == entities.Sensor.NetatmoEngelstoft157IndoorSovevaerelseCo2.EntityId && carbonDioxideChanged.NewEntityState.State <= 1000
        && carbonDioxideChanged.MeasuredAt.TimeOfDay < new TimeSpan(22, 0, 0)
        && carbonDioxideChanged.MeasuredAt.TimeOfDay < new TimeSpan(9, 0, 0);
    }

    public Task DoAction(CarbonDioxideChanged carbonDioxideChanged)
    {
        var notification = new SpeakerNotification()
        {
            EntityId = entities.MediaPlayer.TvStue.EntityId,
            NotificationMessage = $"Der tænger til at blive luftet ud i {entities.Climate.BedroomThermostatThermostat.Area}"
        };
        mediator.Publish(notification);
        return Task.CompletedTask;
    }
}