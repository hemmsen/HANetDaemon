using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daemonapp.Messages
{
    public class BluetoothStateChanged : INotification
    {
        public List<string> DisconnectedConnectedDevices { get; set; }
        public List<string> ConnectedDevice { get; set; }
        public bool IsConnected { get; set; }
    }
}
