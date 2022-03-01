namespace HemmsenHA.apps
{
    [NetDaemonApp]
    [Focus]
    public class BatterySwitchApp
    {
        public BatterySwitchApp(IHaContext haContext, ILogger<BatterySwitchApp> logger)
        {
            haContext.RegisterServiceCallBack<ServiceData>("callback_demo",
                e => logger.LogInformation("Service called action: {Action} value: {value}", e?.action, e?.value));
        }
        record ServiceData(string? action, int value);
    }
}
