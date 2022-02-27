
namespace HemmsenHA.Infrastructure.Strategies
{
    public class OpenWindowBedroomStrategy : IWindowStateChangedStrategy
    {
        private Entities entities;
        private IServices services;
        private IScheduler scheduler;
        private IMediator mediator;
        public OpenWindowBedroomStrategy(IHaContext haContext, IScheduler scheduler, IMediator mediator)
        {
            entities = new Entities(haContext);
            this.scheduler = scheduler;
            this.mediator = mediator;
            this.services = new Services(haContext);
        }
        public bool CanHandle(WindowStateChanged windowStateChanged)
        {
            return windowStateChanged.EntityId == entities.BinarySensor.BedroomWindow.EntityId;
        }

        public Task DoAction(WindowStateChanged windowStateChanged)
        {
            //Schedule close message here!
            if (windowStateChanged.NewState.IsOn())
            {
                ScheduleNotification(windowStateChanged);
                services.Climate.SetHvacMode(ServiceTarget.FromEntity(entities.Climate.BedroomThermostatThermostat.EntityId), "off");
                return Task.CompletedTask;
            }
            services.Climate.SetHvacMode(ServiceTarget.FromEntity(entities.Climate.BedroomThermostatThermostat.EntityId), "heat");
            return Task.CompletedTask;
        }

        private void ScheduleNotification(WindowStateChanged windowStateChanged)
        {
            scheduler.Schedule(DateTimeOffset.Now.AddMinutes(5), () =>
            {
                var currentTemp = entities.Sensor.NetatmoEngelstoft157IndoorSovevaerelseTemperature;
                var currentCo2 = entities.Sensor.NetatmoEngelstoft157IndoorSovevaerelseCo2;
                var humidity = entities.Sensor.NetatmoEngelstoft157IndoorSovevaerelseHumidity;
                var windowOpen = entities.BinarySensor.BedroomWindow.IsOn();
                if ((currentTemp.State < 17 || currentCo2.State < 600) && DateTime.Now.TimeOfDay < new TimeSpan(22, 0, 0))
                {
                    var notification = new CloseWindowInRoomNotification()
                    {
                        CurrentTemperature = currentTemp.State,
                        EntityId = windowStateChanged.EntityId
                    };
                    if (windowOpen)
                    {
                        mediator.Publish(notification);
                    }
                    else
                    {
                        return;
                    }
                }
                ScheduleNotification(windowStateChanged);
            });
        }
    }
}
