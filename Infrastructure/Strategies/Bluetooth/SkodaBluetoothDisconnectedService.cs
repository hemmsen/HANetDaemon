namespace daemonapp.Infrastructure.Bluetooth
{
    public class SkodaBluetoothDisconnectedService : IBluetoothStrategy
    {
        private readonly ILogger<SkodaBluetoothDisconnectedService> _logger;
        private IServices _services;
        private IEntities _entities;

        public SkodaBluetoothDisconnectedService(ILogger<SkodaBluetoothDisconnectedService> logger, IHaContext haContext)
        {
            _logger = logger;
            _services = new Services(haContext);
            _entities = new Entities(haContext);
        }

        public bool CanHandle(List<string> connectedDevices, List<string> disconnectedDevices, bool isConnected)
        {
            //var skodaBluetoothId = "74:95:EC:A2:07:61";
            var skodaBluetoothId = "CC:98:8B:20:81:2B";
            return disconnectedDevices.Any(x => x.Equals(skodaBluetoothId));
        }

        public Task DoWork(BluetoothStateChanged bluetoothStateChanged)
        {
            _services.Logbook.Log(nameof(SkodaBluetoothDisconnectedService), "Disconnected from Skoda", _entities.Sensor.Pixel5BluetoothConnection.EntityId);
            return Task.Run(() => _logger.LogInformation("State isConnected: {connected}, ConnectedDevices: {ConnectedDevices}, DisconnectedDevices: {disconnectedDevices}", bluetoothStateChanged.IsConnected, bluetoothStateChanged.ConnectedDevice, bluetoothStateChanged.DisconnectedConnectedDevices));
        }
    }
}
