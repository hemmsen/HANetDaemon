using HemmsenHA.Core.Configuration;
using Microsoft.Extensions.Options;

namespace HemmsenHA.Tests
{
    public class CarbonDioxideGreenLevelLivingroomStrategyTests
    {
        [Theory]
        [InlineData("500", "600")]
        [InlineData("700", "500")]
        [InlineData("800", "1100")]
        [InlineData("999", "1100")]
        public void TestGreenStrategy_CanHandle_ReturnsTrue(string newCarbonLevel, string oldCarbonLevel)
        {
            var haContext = Substitute.For<IHaContext>();
            var entities = new Entities(haContext);
            var services = new Services(haContext);
            var scheduler = new TestScheduler();
            var mediator = Substitute.For<IMediator>();
            var config = new HaConfigOptions() { CO2YellowLow = 1000, CO2YellowHigh = 2250 };
            var options = Substitute.For<IOptionsSnapshot<HaConfigOptions>>();
            options.Value.ReturnsForAnyArgs(config);
            var co2StrategyGreen = new CarbonDioxideGreenLevelLivingroomStrategy(entities, services, scheduler, mediator, options);

            var co2ChangedEvent = new CarbonDioxideChanged()
            {
                EntityId = entities.Sensor.NetatmoEngelstoft157IndoorCo2.EntityId,
                NewEntityState = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = newCarbonLevel }),
                OldEntityState = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = oldCarbonLevel })
            };

            co2StrategyGreen.CanHandle(co2ChangedEvent).Should().BeTrue();
        }

        [Theory]
        [InlineData("1500", "800")]
        [InlineData("1001", "800")]
        [InlineData("10000", "2000")]
        public void TestGreenStrategy_CanHandle_ReturnsFalse(string newCarbonLevel, string oldCarbonLevel)
        {
            var haContext = Substitute.For<IHaContext>();
            var entities = new Entities(haContext);
            var services = new Services(haContext);
            var scheduler = new TestScheduler();
            var mediator = Substitute.For<IMediator>();
            var config = new HaConfigOptions() { CO2YellowLow = 1000, CO2YellowHigh = 2250 };
            var options = Substitute.For<IOptionsSnapshot<HaConfigOptions>>();
            options.Value.ReturnsForAnyArgs(config);
            var co2StrategyGreen = new CarbonDioxideGreenLevelLivingroomStrategy(entities, services, scheduler, mediator, options);

            var co2ChangedEvent = new CarbonDioxideChanged()
            {
                EntityId = entities.Sensor.NetatmoEngelstoft157IndoorCo2.EntityId,
                NewEntityState = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = newCarbonLevel }),
                OldEntityState = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = oldCarbonLevel })
            };

            co2StrategyGreen.CanHandle(co2ChangedEvent).Should().BeFalse();
        }
    }

}