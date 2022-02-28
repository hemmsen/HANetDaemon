namespace HemmsenHA.Infrastructure.Strategies.CarbonDioxide
{
    public class CarbonDioxideRedLevelLivingroomStrategy : ICarbonDioxideChangedStrategy
    {
        private Entities entities;
        private IServices services;
        private readonly IMediator mediator;
        public CarbonDioxideRedLevelLivingroomStrategy(IHaContext haContext, IScheduler scheduler, IMediator mediator)
        {
            entities = new Entities(haContext);
            this.services = new Services(haContext);
            this.mediator = mediator;
        }

        public bool CanHandle(CarbonDioxideChanged carbonDioxideChanged)
        {
            return carbonDioxideChanged.EntityId == entities.Sensor.NetatmoEngelstoft157IndoorCo2.EntityId && carbonDioxideChanged.NewCarbonDioxide.State >= 2250;
        }

        public async Task DoAction(CarbonDioxideChanged carbonDioxideChanged)
        {
            var lightState = entities.Light.LivingroomLights.EntityState;
            services.Light.TurnOn(ServiceTarget.FromEntity(entities.Light.LivingroomLights.EntityId), new LightTurnOnParameters() { Flash = "short" });
            
            //build notification
            var notificationMessage = new SpeakerNotification()
            {
                EntityId = entities.MediaPlayer.TvStue.EntityId,
                NotificationMessage = $"Kultioxid niveau i {entities.MediaPlayer.TvStue.Area} er nu på {carbonDioxideChanged.NewCarbonDioxide.State} ppm. Luft ud med det samme!"
            };

            //Send speaker notification
            await mediator.Publish(notificationMessage);

            services.Light.TurnOn(ServiceTarget.FromEntity(entities.Light.LivingroomLights.EntityId), new LightTurnOnParameters() { Flash = "short" });
            
            //If old state is off then turn off light again
            if (lightState.IsOff())
            {
                services.Light.TurnOff(ServiceTarget.FromEntity(entities.Light.LivingroomLights.EntityId));
            }
        }
    }
}
