#pragma warning disable CA1812
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
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.Configure<HaConfigOptions>(context.Configuration);
            services
                .AddAppsFromAssembly(Assembly.GetExecutingAssembly())
                .AddNetDaemonStateManager()
                .AddNetDaemonScheduler();
            services.AddTransient<IWindowStateChangedStrategy, OpenWindowBedroomStrategy>();
            services.AddTransient<IWindowStateChangedStrategy, OpenWindowEvaStrategy>();
            services.AddSingleton<ICarbonDioxideChangedStrategy, CarbonDioxideYellowLevelLivingroomStrategy>();
            services.AddTransient<ICarbonDioxideChangedStrategy, CarbonDioxideRedLevelLivingroomStrategy>();
            services.AddSingleton<ICarbonDioxideChangedStrategy, CarbonDioxideGreenLevelLivingroomStrategy>();
            services.AddTransient<ICarbonDioxideChangedStrategy, CarbonDioxideYellowLevelBedroomStrategy>();
            services.AddTransient<INextAlarmOnPhoneChangedStrategy, MathiasPhoneNextAlarmChanged>();
            services.AddTransient<IEntities>(s => new Entities(s.GetRequiredService<IHaContext>()));
            services.AddTransient<IServices>(s => new Services(s.GetRequiredService<IHaContext>()));
            services.AddTransient<ITemperatureChangedStrategy, LowTemperatureBedroomStrategy>();
            services.AddTransient<ITemperatureChangedStrategy, LowTemperatureEvaStrategy>();
            services.AddTransient<ITemperatureChangedStrategy, HighTempBedroomStrategy>();
            services.AddTransient<IMotionSensorChangedStrategy, BathroomMotionSensorEveningStrategy>();
            services.AddTransient<IMotionSensorChangedStrategy, BathroomMotionSensorNightStrategy>();
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