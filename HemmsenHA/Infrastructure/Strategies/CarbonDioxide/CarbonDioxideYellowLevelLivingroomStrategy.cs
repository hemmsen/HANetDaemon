namespace HemmsenHA.Infrastructure.Strategies.CarbonDioxide
{
    public class CarbonDioxideYellowLevelLivingroomStrategy : ICarbonDioxideChangedStrategy
    {
        private Entities entities;
        private IServices services;
        public CarbonDioxideYellowLevelLivingroomStrategy(IHaContext haContext, IScheduler scheduler, IMediator mediator)
        {
            entities = new Entities(haContext);
            this.services = new Services(haContext);
        }

        public bool CanHandle(CarbonDioxideChanged carbonDioxideChanged)
        {
            return carbonDioxideChanged.EntityId == entities.Sensor.NetatmoEngelstoft157IndoorCo2.EntityId && carbonDioxideChanged.NewCarbonDioxide.State >= 1000 && carbonDioxideChanged.OldCarbonDioxide.State < 1000;
        }

        public Task DoAction(CarbonDioxideChanged carbonDioxideChanged)
        {
            //Check current light state
            var lightStateLivingroom = entities.Light.LivingroomLights.EntityState;
            var lightStateKitchen = entities.Light.LivingroomLights.EntityState;
            
            //Flash lights
            services.Light.TurnOn(ServiceTarget.FromEntities(entities.Light.LivingroomLights.EntityId, entities.Light.KokkenSpotsLevelOnOff.EntityId), new LightTurnOnParameters() { Flash = "short" });
            
            //If old state is off then turn off light again
            if (lightStateLivingroom.IsOff())
            {
                services.Light.TurnOff(ServiceTarget.FromEntity(entities.Light.LivingroomLights.EntityId));
            }
            if (lightStateKitchen.IsOff())
            {
                services.Light.TurnOff(ServiceTarget.FromEntity(entities.Light.KokkenSpotsLevelOnOff.EntityId));
            }
            return Task.CompletedTask;
        }
    }
}
