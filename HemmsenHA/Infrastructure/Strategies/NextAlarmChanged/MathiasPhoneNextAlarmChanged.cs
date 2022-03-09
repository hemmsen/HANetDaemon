namespace HemmsenHA.Infrastructure.Strategies;

public class MathiasPhoneNextAlarmChanged : INextAlarmOnPhoneChangedStrategy
{
    private readonly IEntities entities;
    private readonly IServices services;
    private readonly IScheduler scheduler;
    private readonly HaConfigOptions haConfigOptions;
    private readonly ILogger<MathiasPhoneNextAlarmChanged> logger;
    public MathiasPhoneNextAlarmChanged(IEntities entities, IServices services, IScheduler scheduler, IOptionsSnapshot<HaConfigOptions> options, ILogger<MathiasPhoneNextAlarmChanged> logger)
    {
        this.entities = entities;
        this.services = services;
        this.scheduler = scheduler;
        haConfigOptions = options.Value;
        this.logger = logger;
    }
    public bool CanHandle(NextMobileAlarmChanged nextMobileAlarmChanged)
    {
        return nextMobileAlarmChanged.EntityId == entities.Sensor.Pixel5NextAlarm.EntityId;
    }

    public void DoWork(NextMobileAlarmChanged nextMobileAlarmChanged)
    {
        var nextAlarm = DateTime.Parse(nextMobileAlarmChanged?.NewEntityState?.State);

        var schedulerStart = DateTimeOffset.Parse(nextAlarm.AddMinutes(-haConfigOptions.MinutesToStartEspressoMachineBeforeAlarm).ToString());
        logger.LogInformation("Setting espressomachine to start at {starttime}", schedulerStart);

        scheduler.Schedule(schedulerStart, () =>
        {
            var currentState = entities.Sensor.Pixel5NextAlarm.State;
            var s1 = (DateTime.Parse(currentState).AddMinutes(-15) - DateTime.Now).TotalSeconds;
            if (currentState != null && currentState != "unavailable" && s1 < 30)
            {
                services.Switch.TurnOn(ServiceTarget.FromEntity(entities.Switch.KaffemaskineOnOff.EntityId));
            }
        });
    }
}
