namespace daemonapp.apps.MobilePhones
{
    /// <summary>
    /// This app handles turning on/off the espresso machine 
    /// Triggers are sensors from mobile phones connected to home assistant
    /// </summary>
    [NetDaemonApp]
    //[Focus]
    public class WakeUpTurnOnEspressoMachineApp
    {
        public WakeUpTurnOnEspressoMachineApp(IHaContext hAContext, ILogger<WakeUpTurnOnEspressoMachineApp> logger, INetDaemonScheduler scheduler)
        {
            try
            {
                logger.LogInformation("Started application {appName}!", nameof(WakeUpTurnOnEspressoMachineApp));
                var entities = new Entities(hAContext);
                var services = new Services(hAContext);

                entities.BinarySensor.Pixel5IsCharging
                   .StateChanges()
                   .Throttle(new TimeSpan(0, 0, 30))
                   .Where(x => x.Old.State == "off" && x.New.State == "on")
                   .Subscribe(x =>
                   {
                       logger.LogDebug("Old state: {OldState} and new State: {NewState}", x?.Old?.State, x?.New?.State);
                   });

                entities.Sensor.Pixel5NextAlarm
                    .StateChanges()
                    .Subscribe(x =>
                    {
                        if (x?.New?.State != null && x.New.State != "unavailable")
                        {
                            var dt = DateTime.Parse(x.New.State);
                            var dtStr = dt.ToString("yyyy-MM-dd HH:mm:ss");
                            logger.LogInformation("Setting next alarm for Mathias to {nextAlarm}", dtStr);
                            services.InputDatetime.SetDatetime(ServiceTarget.FromEntity(entities.InputDatetime.Nextalarmmathias.EntityId), new InputDatetimeSetDatetimeParameters() { Datetime = dtStr });
                            scheduler.RunAt(DateTimeOffset.Parse(dt.AddMinutes(-15).ToString()), () =>
                            {
                                var currentState = entities.Sensor.Pixel5NextAlarm.State;
                                var now = DateTime.Now;
                                var s1 = (DateTime.Parse(currentState).AddMinutes(-15) - now).TotalSeconds;
                                if (currentState != null && currentState != "unavailable" && s1 < 30)
                                {
                                    services.Switch.TurnOn(ServiceTarget.FromEntity(entities.Switch.KaffemaskineOnOff.EntityId));
                                }
                            });
                        }
                        else
                        {
                            var maxDtStr = DateTime.MaxValue.ToString("yyyy-MM-dd HH:mm:ss");
                            services.InputDatetime.SetDatetime(ServiceTarget.FromEntity(entities.InputDatetime.Nextalarmmathias.EntityId), new InputDatetimeSetDatetimeParameters() { Datetime = maxDtStr });
                        }
                    });
            }
            catch (Exception ex)
            {
                logger.LogCritical(ex, "Error starting {AppName}", nameof(WakeUpTurnOnEspressoMachineApp));
            }
        }
    }
}