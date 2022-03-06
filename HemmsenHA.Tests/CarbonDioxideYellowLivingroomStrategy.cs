namespace HemmsenHA.Tests
{
    public class CarbonDioxideYellowLevelLivingroomStrategyTests
    {
        [Theory]
        [InlineData("1500", "800")]
        [InlineData("1001", "800")]
        [InlineData("10000", "2000")]
        public void TestYellowStrategy_CanHandle_ReturnsTrue(string newCarbonLevel, string oldCarbonLevel)
        {
            var entities = Substitute.For<IEntities>();
            var services = Substitute.For<IServices>();
            var scheduler = new TestScheduler();
            var mediator = Substitute.For<IMediator>();
            var co2StrategyYellow = new CarbonDioxideYellowLevelLivingroomStrategy(entities, services, scheduler);

            var co2ChangedEvent = new CarbonDioxideChanged()
            {
                EntityId = entities.Sensor.NetatmoEngelstoft157IndoorCo2.EntityId,
                NewEntityState = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = newCarbonLevel }),
                OldEntityState = new NumericEntityState<NumericSensorAttributes>(new EntityState() { State = oldCarbonLevel })
            };

            co2StrategyYellow.CanHandle(co2ChangedEvent).Should().BeTrue();
        }

        [Theory]
        [InlineData("1500", "800")]
        [InlineData("1001", "800")]
        [InlineData("10000", "2000")]
        public void TestYellowStrategy_CanHandle_ReturnsFalse(string newCarbonLevel, string oldCarbonLevel)
        {
            var entities = Substitute.For<IEntities>();
            var services = Substitute.For<IServices>();
            var scheduler = new TestScheduler();
            var mediator = Substitute.For<IMediator>();
            var co2StrategyYellow = new CarbonDioxideYellowLevelLivingroomStrategy(entities, services, scheduler);

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