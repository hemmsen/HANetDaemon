#pragma warning disable CA1812


try
{
    await Host.CreateDefaultBuilder(args)
        .UseCustomLogging()
        .UseNetDaemonDefaultLogging()
        .UseNetDaemonAppSettings()
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
            services.AddScoped<ICarbonDioxideChangedStrategy, CarbonDioxideYellowLevelLivingroomStrategy>();
            services.AddScoped<ICarbonDioxideChangedStrategy, CarbonDioxideRedLevelLivingroomStrategy>();
            services.AddScoped<ICarbonDioxideChangedStrategy, CarbonDioxideGreenLevelLivingroomStrategy>();
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