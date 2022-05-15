using HemmsenHA.Infrastructure.Strategies;

namespace HemmsenHA.Tests
{
    public class ToiletMotionSensorStrategyTests
    {
        [Fact]
        public void CanHandle_ReturnsTrue()
        {
            var haContext = Substitute.For<IHaContext>();
            var entities = new Entities(haContext);
            var motionSensorStateActive = new MotionSensorStateActive() { EntityId = entities.BinarySensor.MotionToiletIasZone2.EntityId };
            var services = Substitute.For<IServices>();
            var sut = new ToiletMotionSensorStrategy(entities, services);
            sut.CanHandle(motionSensorStateActive).Should().BeTrue();
        }

        [Fact]
        public void CanHandle_ReturnsFalse()
        {
            var haContext = Substitute.For<IHaContext>();
            var entities = new Entities(haContext);
            var motionSensorStateActive = new MotionSensorStateActive() { EntityId = entities.BinarySensor.MotionBathroomIasZone.EntityId };
            var services = Substitute.For<IServices>();
            var sut = new ToiletMotionSensorStrategy(entities, services);
            sut.CanHandle(motionSensorStateActive).Should().BeFalse();
        }

        [Fact]
        public void DoAction_LightTurnedOn()
        {
            var haContext = Substitute.For<IHaContext>();
            var entities = new Entities(haContext);
            var motionSensorStateActive = new MotionSensorStateActive() { EntityId = entities.BinarySensor.MotionToiletIasZone2.EntityId, LightEntityId = entities.Light.ToiletOnOff.EntityId };
            var services = Substitute.For<IServices>();
            var lightService = Substitute.For<LightServices>(haContext);
            services.Light.ReturnsForAnyArgs(lightService);
            var lightTurnOn = false;
            haContext.When(x => x.CallService("light", "turn_on", Arg.Any<ServiceTarget>(), Arg.Any<LightTurnOnParameters>())).Do(x =>
            {
                lightTurnOn = true;
            });
            var sut = new ToiletMotionSensorStrategy(entities, services);
            sut.DoAction(motionSensorStateActive);
            lightTurnOn.Should().BeTrue();
        }
    }
}