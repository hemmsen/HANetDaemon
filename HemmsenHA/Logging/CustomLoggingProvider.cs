namespace HemmsenHA.Logging;
public static class CustomLoggingProvider
{
    /// <summary>
    ///     Adds standard serilog logging configuration, from appsettings, as per:
    ///     https://github.com/datalust/dotnet6-serilog-example
    /// </summary>
    /// <param name="builder"></param>
    public static IHostBuilder UseCustomLogging(this IHostBuilder builder)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        var logPath = $"{AppDomain.CurrentDomain.BaseDirectory}/../Logs/log.log";
        var logger = new LoggerConfiguration()
        .MinimumLevel.Information()
        .WriteTo.File(logPath, rollingInterval: RollingInterval.Day)
        .WriteTo.Console(restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Debug)
        .CreateLogger();
        Log.Logger = logger;
        return builder.UseSerilog(logger);
    }
}
