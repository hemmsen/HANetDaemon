namespace HemmsenHA.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static void ConfigureMyServices(this IServiceCollection services, HostBuilderContext context)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.Configure<HaConfigOptions>(context.Configuration);
        services
            .AddAppsFromAssembly(Assembly.GetExecutingAssembly())
            .AddNetDaemonStateManager()
            .AddNetDaemonScheduler();
        services.AddTransient<IWindowStateChangedStrategy, OpenWindowBedroomStrategy>();
        services.AddTransient<IWindowStateChangedStrategy, ClosedWindowBedroomStrategy>();
        services.AddTransient<IWindowStateChangedStrategy, OpenWindowEvaStrategy>();
        services.AddTransient<IWindowStateChangedStrategy, ClosedWindowEvaStrategy>();
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
        services.AddTransient<ITemperatureChangedStrategy, DecreaseTemperatureEvaStrategy>();
        services.AddTransient<IMotionSensorChangedStrategy, BathroomMotionSensorEveningStrategy>();
        services.AddTransient<IMotionSensorChangedStrategy, BathroomMotionSensorNightStrategy>();
        services.AddTransient<IMotionSensorChangedStrategy, ToiletMotionSensorStrategy>();
        services.AddTransient<ILightStateChangedStrategy, EvaLightChangedStrategy>();
        services.AddTransient<ILightStateChangedStrategy, EvaLightTurnedOnStrategy>();
    }
}