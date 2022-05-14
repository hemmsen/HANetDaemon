using HemmsenHA.apps.MotionsSensors;
using HemmsenHA.Core.Configuration;
using HemmsenHA.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using NetDaemon.Daemon.Fakes;
namespace HemmsenHA.Tests
{
    public class MotionSensorStateChangedTests : RxAppMock
    {
        [Fact]
        public void TestName()
        {
            // // Given
            // // var serviceCollection = new ServiceCollection();
            // // serviceCollection.ConfigureMyServices()
            // var haContext = Substitute.For<IHaContext>();
            // var entities = new Entities(haContext);
            // var mediator = Substitute.For<IMediator>();
            // var services = Substitute.For<IServices>();
            // var logger = Substitute.For<ILogger<ToiletMotionSensorApp>>();
            // var options = Substitute.For<IOptionsMonitor<HaConfigOptions>>();

            // var app = new ToiletMotionSensorApp(entities, mediator, logger, options);

            // // When
            // TriggerStateChange(new Entities(haContext).BinarySensor.MotionToiletIasZone2.EntityId, "off", "on");

            // // Then
            // VerifyEntityTurnOn(new Entities(haContext).Light.ToiletOnOff.EntityId);
        }
    }
}