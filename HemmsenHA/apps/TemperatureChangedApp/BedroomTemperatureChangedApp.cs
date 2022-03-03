namespace HemmsenHA.apps.TemperatureChangedApp
{
    [NetDaemonApp]
    public class BedroomTemperatureChangedApp
    {
        public BedroomTemperatureChangedApp(IHaContext haContext, IMediator mediator)
        {
            var entities = new Entities(haContext);

            entities.Climate.BedroomThermostatThermostat
                .StateAllChanges()
                .Subscribe(entitystate =>
                {
                    var tempChanged = new ClimateChangedNotification()
                    {
                        EntityId = entitystate.Entity.EntityId,
                        NewEntityState = entitystate?.New,
                        OldEntityState = entitystate?.Old
                    };
                    mediator.Publish(tempChanged);
                });
        }
    }
}
