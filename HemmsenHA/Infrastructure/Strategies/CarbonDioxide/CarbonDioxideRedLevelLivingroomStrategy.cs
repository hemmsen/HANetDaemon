namespace HemmsenHA.Infrastructure.Strategies.CarbonDioxide
{
    public class CarbonDioxideRedLevelLivingroomStrategy : ICarbonDioxideChangedStrategy
    {
        private IEntities entities;
        private IServices services;
        private readonly IMediator mediator;
        private readonly IOptionsMonitor<HaConfigOptions> haConfigOptions;
        public CarbonDioxideRedLevelLivingroomStrategy(IEntities entities, IServices services, IMediator mediator, IOptionsMonitor<HaConfigOptions> options)
        {
            this.entities = entities;
            this.services = services;
            this.mediator = mediator;
            haConfigOptions = options;
        }

        public bool CanHandle(CarbonDioxideChanged carbonDioxideChanged)
        {
            return carbonDioxideChanged.EntityId == entities.Sensor.NetatmoEngelstoft157IndoorCo2.EntityId && carbonDioxideChanged.NewEntityState.State >= haConfigOptions.CurrentValue.CO2YellowHigh;
        }

        public async Task DoAction(CarbonDioxideChanged carbonDioxideChanged)
        {
            var lightState = entities.Light.LivingroomLights.EntityState;
            services.Light.TurnOn(ServiceTarget.FromEntity(entities.Light.LivingroomLights.EntityId), new LightTurnOnParameters() { Flash = "short" });

            //build notification
            var notificationMessage = new SpeakerNotification()
            {
                EntityId = entities.MediaPlayer.TvStue.EntityId,
                NotificationMessage = $"Kultioxid niveau i {entities.MediaPlayer.TvStue.Area} er nu på {carbonDioxideChanged.NewEntityState.State} ppm. Luft ud med det samme!"
            };

            //Send speaker notification
            await mediator.Publish(notificationMessage);

            services.Light.TurnOn(ServiceTarget.FromEntity(entities.Light.LivingroomLights.EntityId), new LightTurnOnParameters() { Flash = "short" });

            // Delay to wait for flash to complate
            await Task.Delay(5000);
            //If old state is off then turn off light again
            if (lightState.IsOff())
            {
                services.Light.TurnOff(ServiceTarget.FromEntity(entities.Light.LivingroomLights.EntityId));
            }
        }
    }
}
