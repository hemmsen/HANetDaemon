namespace HemmsenHA.apps.Kitchen
{
    [NetDaemonApp]
    public class EspressoMachineApp
    {
        public EspressoMachineApp(IHaContext haContext, IMediator mediator, ILogger<EspressoMachineApp> logger)
        {
            try
            {
                var entities = new Entities(haContext);
                logger.LogInformation($"{nameof(EspressoMachineApp)} started!");
                entities.Sensor.KaffemaskineSmartenergyMetering
                    .StateChanges()
                    .Throttle(new TimeSpan(0, 0, 30))
                    .Subscribe(x =>
                    {
                        mediator.Publish(new ProfitecHeatingMessage() { CurrentState = x?.New });
                    });

                entities.Sensor.KaffemaskineSmartenergyMetering
                    .StateChanges()
                    .Subscribe(state =>
                    {
                        logger.LogTrace("Current state changed! New value {newValue} and old value {oldValue}", state?.New?.State, state?.Old?.State);
                        var currentMeasurementChanged = new ProfitecCurrentMeasurementChanged()
                        {
                            CurrentPowerConsumption = state?.New?.State,
                            OldPowerConsumption = state?.Old?.State,
                            ReadyDatetimeOffset = DateTimeOffset.Now
                        };
                        mediator.Publish(currentMeasurementChanged);
                    });

                entities.Switch.KaffemaskineOnOff
                    .StateChanges()
                    .Subscribe(state =>
                    {
                        if (state?.New != null && state?.Old != null)
                        {
                            logger.LogDebug("Current {statename} state changed! Old state: {oldState}, new State: {newState}", nameof(entities.Switch.KaffemaskineOnOff), state?.Old?.State, state?.New?.State);
                            var message = new ProfitecStateChanged()
                            {
                                OldState = state.Old,
                                NewState = state.New
                            };
                            mediator.Publish(message);
                            return;
                        }
                        throw new ArgumentNullException("State is null for either new or old for Entity with EntityId: {EntityId}", state?.Entity.EntityId);

                    });
            }
            catch (Exception ex)
            {
                logger.LogCritical(ex, "Error starting {AppName}", nameof(EspressoMachineApp));
            }

        }
    }
}
