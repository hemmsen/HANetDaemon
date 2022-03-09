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
            services.AddScoped<IWindowStateChangedStrategy, OpenWindowBedroomStrategy>();
            services.AddScoped<IWindowStateChangedStrategy, OpenWindowEvaStrategy>();
            services.AddScoped<ICarbonDioxideChangedStrategy, CarbonDioxideYellowLevelLivingroomStrategy>();
            services.AddScoped<ICarbonDioxideChangedStrategy, CarbonDioxideRedLevelLivingroomStrategy>();
            services.AddScoped<ICarbonDioxideChangedStrategy, CarbonDioxideGreenLevelLivingroomStrategy>();
            services.AddTransient<ICarbonDioxideChangedStrategy, CarbonDioxideYellowLevelBedroomStrategy>();
            services.AddScoped<INextAlarmOnPhoneChangedStrategy, MathiasPhoneNextAlarmChanged>();
            services.AddScoped<IEntities>(s => new Entities(s.GetRequiredService<IHaContext>()));
            services.AddScoped<IServices>(s => new Services(s.GetRequiredService<IHaContext>()));
            services.AddTransient<ITemperatureChangedStrategy, LowTemperatureBedroomStrategy>();
            services.AddTransient<ITemperatureChangedStrategy, LowTemperatureEvaStrategy>();
            services.AddTransient<ITemperatureChangedStrategy, HighTempBedroomStrategy>();
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