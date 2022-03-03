namespace HemmsenHA.Infrastructure.Strategies.CarbonDioxide
{
    public class CarbonDioxideYellowLevelLivingroomStrategy : ICarbonDioxideChangedStrategy
    {
        private IEntities _entities;
        private IServices _services;
        public CarbonDioxideYellowLevelLivingroomStrategy(IEntities entities, IServices services, IScheduler scheduler)
        {
            _entities = entities;
            _services = services;
        }

        public bool CanHandle(CarbonDioxideChanged carbonDioxideChanged)
        {
            return carbonDioxideChanged.EntityId == _entities.Sensor.NetatmoEngelstoft157IndoorCo2.EntityId && carbonDioxideChanged?.NewEntityState?.State >= 1000 && carbonDioxideChanged.NewEntityState.State < 1000;
        }

        public Task DoAction(CarbonDioxideChanged carbonDioxideChanged)
        {
            //Check current light state
            var lightStateLivingroomIsOff = _entities.Light.LivingroomLights.EntityState.IsOff();
            var lightStateKitchenIsOff = _entities.Light.KokkenSpotsLevelOnOff.EntityState.IsOff();

            //Flash lights
            _services.Light.TurnOn(ServiceTarget.FromEntities(_entities.Light.LivingroomLights.EntityId, _entities.Light.KokkenSpotsLevelOnOff.EntityId), new LightTurnOnParameters() { Flash = "short" });

            //If old state is off then turn off light again
            if (lightStateLivingroomIsOff)
            {
                _services.Light.TurnOff(ServiceTarget.FromEntity(_entities.Light.LivingroomLights.EntityId));
            }
            if (lightStateKitchenIsOff)
            {
                _services.Light.TurnOff(ServiceTarget.FromEntity(_entities.Light.KokkenSpotsLevelOnOff.EntityId));
            }
            return Task.CompletedTask;
        }
    }
}
