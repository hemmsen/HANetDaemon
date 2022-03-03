using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemmsenHA.Infrastructure.Strategies.CarbonDioxide
{
    public class CarbonDioxideGreenLevelLivingroomStrategy : ICarbonDioxideChangedStrategy
    {
        private Entities entities;
        private IServices services;
        public CarbonDioxideGreenLevelLivingroomStrategy(IHaContext haContext, IScheduler scheduler, IMediator mediator)
        {
            entities = new Entities(haContext);
            this.services = new Services(haContext);
        }

        public bool CanHandle(CarbonDioxideChanged carbonDioxideChanged)
        {
            return carbonDioxideChanged.EntityId == entities.Sensor.NetatmoEngelstoft157IndoorCo2.EntityId && carbonDioxideChanged.NewEntityState.State <= 1000;
        }

        public Task DoAction(CarbonDioxideChanged carbonDioxideChanged)
        {
            return Task.CompletedTask;
        }
    }
}
