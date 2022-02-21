using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            services.Light.TurnOn(ServiceTarget.FromEntity(entities.Light.LivingroomLights.EntityId), new LightTurnOnParameters() { Flash = "short" });
            return Task.CompletedTask;
        }
    }
}
