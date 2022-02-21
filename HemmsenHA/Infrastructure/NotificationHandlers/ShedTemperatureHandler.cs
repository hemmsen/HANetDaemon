using System.Threading;

namespace daemonapp.Handlers
{
    public class ShedTemperatureHandler : INotificationHandler<NetatmoOutdoorMeasurementChanged>
    {
        private IServices _services;
        private IEntities _entities;
        private ILogger<ShedTemperatureHandler> _logger;

        public ShedTemperatureHandler(IHaContext haContext, ILogger<ShedTemperatureHandler> logger)
        {
            _services = new Services(haContext);
            _entities = new Entities(haContext);
            _logger = logger;
        }
        public Task Handle(NetatmoOutdoorMeasurementChanged notification, CancellationToken cancellationToken)
        {
            if (notification.CurrentTemperature <= 3)
            {
                var newTargetTemp = 8;
                _logger.LogDebug("Set temperature to: {newTemp}", newTargetTemp);
                _services.Climate.SetTemperature(ServiceTarget.FromEntity(_entities.Climate.Skur.EntityId), newTargetTemp);
                _services.Logbook.Log(nameof(ShedTemperatureHandler), $"Climate in skur set to {newTargetTemp}", _entities.Climate.Skur.EntityId);
            }
            else if (notification.CurrentTemperature <= 8)
            {
                var newTargetTemp = notification.CurrentTemperature + 5;
                _logger.LogDebug("Set temperature to: {newTemp}", newTargetTemp);
                _services.Climate.SetTemperature(ServiceTarget.FromEntity(_entities.Climate.Skur.EntityId), newTargetTemp);
                _services.Logbook.Log(nameof(ShedTemperatureHandler), $"Climate in skur set to {newTargetTemp}", _entities.Climate.Skur.EntityId);
            }
            else if (notification.CurrentTemperature <= 15)
            {
                var newTargetTemp = notification.CurrentTemperature + 3;
                _logger.LogDebug("Set temperature to: {newTemp}", notification.CurrentTemperature);
                _services.Climate.SetTemperature(ServiceTarget.FromEntity(_entities.Climate.Skur.EntityId), notification.CurrentTemperature);
                _services.Logbook.Log(nameof(ShedTemperatureHandler), $"Climate in skur set to {notification.CurrentTemperature}", _entities.Climate.Skur.EntityId);
            }
            else if (notification.CurrentTemperature >= 15)
            {
                _logger.LogDebug("CurrentOurdoorTemp: {outdootTemp} - Turn off heating in the shed!", notification.CurrentTemperature);
                _services.Climate.TurnOff(ServiceTarget.FromEntity(_entities.Climate.Skur.EntityId));
                _services.Logbook.Log(nameof(ShedTemperatureHandler), $"Climate in skur turned off", _entities.Climate.Skur.EntityId);
            }
            else
            {
                _logger.LogDebug("No action!");
            }
            return Task.CompletedTask;
        }
    }
}
