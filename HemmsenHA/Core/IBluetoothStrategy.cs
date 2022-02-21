using daemonapp.Messages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace daemonapp.Core
{
    public interface IBluetoothStrategy
    {
        bool CanHandle(List<string> connectedDevices, List<string> disconnectedDevices, bool isConnected);

        Task DoWork(BluetoothStateChanged bluetoothStateChanged);
    }
}
