using HemmsenHA.Core.Configuration;
using Microsoft.Extensions.Options;
using NetDaemon.Daemon.Fakes;

namespace HemmsenHA.Tests
{
    public class CarbonDioxideYellowLevelLivingroomStrategyTests
    {
        [Theory]
        [InlineData("1500", "800")]
        [InlineData("1001", "800")]
        [InlineData("1201", "700")]
        public void TestYellowStrategy_CanHandle_ReturnsTrue(string newCarbonLevel, string oldCarbonLevel)
        {
            var haContext = Substitute.For<IHaContext>();
            var entities = new Entities(haContext);
            var services = new Services(haContext);
            var mediator = Substitute.For<IMediator>();
            var config = new HaConfigOptions() { CO2GreenHigh = 1000, CO2YellowHigh = 2250 };
            var options = Substitute.For<IOptionsMonitor<HaConfigOptions>>();
            options.CurrentValue.ReturnsForAnyArgs(config);
            var co2StrategyYellow = new CarbonDioxideYellowLevelLivingroomStrategy(entities, services, options);
            var co2ChangedEvent = new CarbonDioxideChanged()
            {
                EntityId = entities.Sensor.NetatmoEngelstoft157IndoorCo2.EntityId,
                NewEntityState = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = newCarbonLevel }),
                OldEntityState = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = oldCarbonLevel })
            };

            co2StrategyYellow.CanHandle(co2ChangedEvent).Should().BeTrue();
        }

        [Theory]
        [InlineData("700", "800")]
        [InlineData("999", "800")]
        [InlineData("999", "2000")]
        public void TestYellowStrategy_CanHandle_ReturnsFalse(string newCarbonLevel, string oldCarbonLevel)
        {
            var haContext = Substitute.For<IHaContext>();
            var entities = new Entities(haContext);
            var services = new Services(haContext);
            var mediator = Substitute.For<IMediator>();
            var config = new HaConfigOptions() { CO2GreenHigh = 1000, CO2YellowHigh = 2250 };
            var options = Substitute.For<IOptionsMonitor<HaConfigOptions>>();
            options.CurrentValue.ReturnsForAnyArgs(config);
            var co2StrategyYellow = new CarbonDioxideYellowLevelLivingroomStrategy(entities, services, options);

            var co2ChangedEvent = new CarbonDioxideChanged()
            {
                EntityId = entities.Sensor.NetatmoEngelstoft157IndoorCo2.EntityId,
                NewEntityState = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = newCarbonLevel }),
                OldEntityState = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = oldCarbonLevel })
            };

            co2StrategyYellow.CanHandle(co2ChangedEvent).Should().BeFalse();
        }
    }

}