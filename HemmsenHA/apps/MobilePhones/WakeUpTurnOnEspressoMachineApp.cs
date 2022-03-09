namespace daemonapp.apps.MobilePhones
{
    /// <summary>
    /// This app handles turning on/off the espresso machine 
    /// Triggers are sensors from mobile phones connected to home assistant
    /// </summary>
    [NetDaemonApp]
    [Focus]
    public class WakeUpTurnOnEspressoMachineApp
    {
        public WakeUpTurnOnEspressoMachineApp(IEntities entities, IServices services, ILogger<WakeUpTurnOnEspressoMachineApp> logger, INetDaemonScheduler scheduler, IOptionsSnapshot<HaConfigOptions> options, IMediator mediator)
        {
            try
            {
                logger.LogInformation("Started application {appName}!", nameof(WakeUpTurnOnEspressoMachineApp));

                // This is for weekends, without alarm set on the phone
                entities.BinarySensor.Pixel5IsCharging
                   .StateChanges()
                   .Throttle(new TimeSpan(0, 0, 30))
                   .Where(x => x.Old.State == "off" && x.New.State == "on")
                   .Subscribe(x =>
                   {
                       logger.LogDebug("Old state: {OldState} and new State: {NewState}", x?.Old?.State, x?.New?.State);
                   });

                // This is for weekdays when the alarm is set
                entities.Sensor.Pixel5NextAlarm
                    .StateAllChanges()
                    .Where(state => state?.New?.State != null && state.New.State != "unavailable")
                    .Subscribe(state =>
                    {
                        var notification = new NextMobileAlarmChanged()
                        {
                            OldEntityState = state.Old,
                            NewEntityState = state.New,
                            EntityId = state.Entity.EntityId
                        };
                        mediator.Publish(notification);
                    });
            }
            catch (Exception ex)
            {
                logger.LogCritical(ex, "Error starting {AppName}", nameof(WakeUpTurnOnEspressoMachineApp));
            }
        }
    }
}