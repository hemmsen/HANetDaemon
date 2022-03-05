#pragma warning disable CA1812


try
{
    await Host.CreateDefaultBuilder(args)
        .UseCustomLogging()
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
            services.AddTransient<ICarbonDioxideChangedStrategy, CarbonDioxideYellowLevelBedroomStrategy>();
            services.AddScoped<IEntities>(s => new Entities(s.GetRequiredService<IHaContext>()));
            services.AddScoped<IServices>(s => new Services(s.GetRequiredService<IHaContext>()));
            services.AddTransient<ITemperatureChangedStrategy, LowTemperatureBedroomStrategy>();
            services.AddTransient<ITemperatureChangedStrategy, LowTemperatureEvaStrategy>();
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