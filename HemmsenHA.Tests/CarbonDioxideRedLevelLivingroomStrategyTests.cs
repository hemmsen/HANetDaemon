using HemmsenHA.Core.Configuration;
using Microsoft.Extensions.Options;

namespace HemmsenHA.Tests
{
    public class CarbonDioxideRedLevelLivingroomStrategyTests
    {
        [Theory]
        [InlineData("2250", "1000")]
        [InlineData("2500", "2200")]
        [InlineData("3000", "3001")]
        public void TestRedStrategy_CanHandle_ReturnsTrue(string newCarbonLevel, string oldCarbonLevel)
        {
            var haContext = Substitute.For<IHaContext>();
            var mediator = Substitute.For<IMediator>();
            var options = Substitute.For<IOptionsMonitor<HaConfigOptions>>();
            var haConfigOptions = new HaConfigOptions()
            {
                CO2YellowHigh = 2250
            };
            options.CurrentValue.ReturnsForAnyArgs(haConfigOptions);

            var co2StrategyGreen = new CarbonDioxideRedLevelLivingroomStrategy(new Entities(haContext), new Services(haContext), mediator, options);

            var co2ChangedEvent = new CarbonDioxideChanged()
            {
                EntityId = new Entities(haContext).Sensor.NetatmoEngelstoft157IndoorCo2.EntityId,
                NewEntityState = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = newCarbonLevel }),
                OldEntityState = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = oldCarbonLevel })
            };

            co2StrategyGreen.CanHandle(co2ChangedEvent).Should().BeTrue();
        }

        [Theory]
        [InlineData("1999", "800")]
        [InlineData("2000", "2200")]
        [InlineData("1000", "2000")]
        public void TestRedStrategy_CanHandle_ReturnsFalse(string newCarbonLevel, string oldCarbonLevel)
        {
            var haContext = Substitute.For<IHaContext>();
            var mediator = Substitute.For<IMediator>();
            var options = Substitute.For<IOptionsMonitor<HaConfigOptions>>();
            var haConfigOptions = new HaConfigOptions()
            {
                CO2YellowHigh = 2250
            };
            options.CurrentValue.ReturnsForAnyArgs(haConfigOptions);
            var co2StrategyGreen = new CarbonDioxideRedLevelLivingroomStrategy(new Entities(haContext), new Services(haContext), mediator, options);

            var co2ChangedEvent = new CarbonDioxideChanged()
            {
                EntityId = new Entities(haContext).Sensor.NetatmoEngelstoft157IndoorCo2.EntityId,
                NewEntityState = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = newCarbonLevel }),
                OldEntityState = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = oldCarbonLevel })
            };

            co2StrategyGreen.CanHandle(co2ChangedEvent).Should().BeFalse();
        }
    }

}