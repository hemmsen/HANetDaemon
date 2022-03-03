namespace daemonapp.Messages
{
    public class BluetoothStateChanged : INotification
    {
        public List<string> DisconnectedConnectedDevices { get; set; }
        public List<string> ConnectedDevice { get; set; }
        public bool IsConnected { get; set; }
    }
}
