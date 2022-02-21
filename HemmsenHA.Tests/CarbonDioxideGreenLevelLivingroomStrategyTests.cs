namespace HemmsenHA.Tests
{
    public class CarbonDioxideGreenLevelLivingroomStrategyTests
    {
        [Theory]
        [InlineData("500", "600")]
        [InlineData("700", "500")]
        [InlineData("800", "1100")]
        [InlineData("1000", "1100")]
        public void TestGreenStrategy_CanHandle_ReturnsTrue(string newCarbonLevel, string oldCarbonLevel)
        {
            var haContext = Substitute.For<IHaContext>();
            var scheduler = new TestScheduler();
            var mediator = Substitute.For<IMediator>();
            var co2StrategyGreen = new CarbonDioxideGreenLevelLivingroomStrategy(haContext, scheduler, mediator);

            var co2ChangedEvent = new CarbonDioxideChanged()
            {
                EntityId = new Entities(haContext).Sensor.NetatmoEngelstoft157IndoorCo2.EntityId,
                NewCarbonDioxide = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = newCarbonLevel }),
                OldCarbonDioxide = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = oldCarbonLevel })
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
            var scheduler = new TestScheduler();
            var mediator = Substitute.For<IMediator>();
            var co2StrategyGreen = new CarbonDioxideGreenLevelLivingroomStrategy(haContext, scheduler, mediator);

            var co2ChangedEvent = new CarbonDioxideChanged()
            {
                EntityId = new Entities(haContext).Sensor.NetatmoEngelstoft157IndoorCo2.EntityId,
                NewCarbonDioxide = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = newCarbonLevel }),
                OldCarbonDioxide = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = oldCarbonLevel })
            };

            co2StrategyGreen.CanHandle(co2ChangedEvent).Should().BeFalse();
        }
    }

}