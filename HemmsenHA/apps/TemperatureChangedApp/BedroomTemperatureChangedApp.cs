namespace HemmsenHA.apps.TemperatureChangedApp
{
    [NetDaemonApp]
    public class BedroomTemperatureChangedApp
    {
        public BedroomTemperatureChangedApp(IHaContext haContext, IMediator mediator, ILogger<BedroomTemperatureChangedApp> logger)
        {
            var entities = new Entities(haContext);

            entities.Climate.BedroomThermostatThermostat
                .StateAllChanges()
                .Subscribe(async entitystate =>
                {
                    logger.LogInformation($"Climate state changed for bedroom - Old current tempearture: {entitystate?.Old?.Attributes?.CurrentTemperature} and new current temperature: {entitystate?.New?.Attributes?.CurrentTemperature}");
                    var tempChanged = new ClimateChangedNotification()
                    {
                        EntityId = entitystate.Entity.EntityId,
                        NewEntityState = entitystate?.New,
                        OldEntityState = entitystate?.Old
                    };
                    await mediator.Publish(tempChanged);
                });
        }
    }
}
