#pragma warning disable CA1812
using HemmsenHA.Infrastructure.Strategies;
using HemmsenHA.Infrastructure.Strategies.CarbonDioxide;
using HemmsenHA.Infrastructure.Strategies.Window;

try
{
    await Host.CreateDefaultBuilder(args)
        .UseNetDaemonAppSettings()
        .UseNetDaemonDefaultLogging()
        .UseNetDaemonRuntime()
        .UseNetDaemonTextToSpeech()
        .ConfigureServices((_, services) =>
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services
                .AddAppsFromAssembly(Assembly.GetExecutingAssembly())
                .AddNetDaemonStateManager()
                .AddNetDaemonScheduler();
            services.AddScoped<IWindowStateChangedStrategy, OpenWindowBedroomStrategy>();
            services.AddScoped<IWindowStateChangedStrategy, OpenWindowEvaStrategy>();
            services.AddScoped<ICarbonDioxideChangedStrategy, CarbonDioxideChangedLivingroomStrategy>();
        }
            
            
        )
        .Build()
        .RunAsync()
        .ConfigureAwait(false);
}
catch (Exception e)
{
    Console.WriteLine($"Failed to start host... {e}");
    throw;
}