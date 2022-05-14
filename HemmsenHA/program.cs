#pragma warning disable CA1812
using HemmsenHA.Infrastructure;

try
{
    Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateBootstrapLogger();
    await Host.CreateDefaultBuilder(args)
        .UseCustomLogging()
        .UseNetDaemonAppSettings()
        .ConfigureAppConfiguration((s, configuration) =>
    {
        var tempConfig = configuration.Build();
        var token = tempConfig["HomeAssistant:Token"];
        var host = tempConfig["HomeAssistant:Host"];
        var port = tempConfig["HomeAssistant:Port"];
        Log.Logger.Information($"{token}-{host}-{port}");
        configuration.AddHaRuntimeConfigration(token, $"http://{host}:{port}/api/");
    })
        .UseNetDaemonRuntime()
        .UseNetDaemonTextToSpeech()
        .ConfigureServices((context, services) =>
        {
            services.ConfigureMyServices(context);
        })
        .Build()
        .RunAsync()
        .ConfigureAwait(false);
}
catch (Exception e)
{
    Console.WriteLine($"Failed to start host... {e}");
    throw;
}