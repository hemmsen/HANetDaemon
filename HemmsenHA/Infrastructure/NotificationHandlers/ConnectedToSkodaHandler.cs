using daemonapp.Core;
using daemonapp.Messages;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace daemonapp.Handlers
{
    public class BluetoothConnectionChangedHandler : INotificationHandler<BluetoothStateChanged>
    {
        private IEnumerable<IBluetoothStrategy> _bluetoothStrategies;

        public BluetoothConnectionChangedHandler(IEnumerable<IBluetoothStrategy> bluetoothStrategies)
        {
            _bluetoothStrategies = bluetoothStrategies;
        }
        public Task Handle(BluetoothStateChanged notification, CancellationToken cancellationToken)
        {
            //Find the right strategy
            var strategy = _bluetoothStrategies.First(x => x.CanHandle(notification.ConnectedDevice, notification.DisconnectedConnectedDevices, notification.IsConnected));

            strategy.DoWork(notification);
            return Task.CompletedTask;
        }
    }
}
