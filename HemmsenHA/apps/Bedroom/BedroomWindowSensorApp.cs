using Microsoft.Extensions.Options;

namespace HemmsenHA.apps.Bedroom;

[NetDaemonApp]
[Focus]
public class BedroomWindowSensorApp
{
    public BedroomWindowSensorApp(IEntities entities, IMediator mediator, ILogger<BedroomWindowSensorApp> logger, IServices services, IOptionsMonitor<HaConfigOptions> optionsMonitor)
    {
        try
        {
            entities.BinarySensor.BedroomWindow
                .StateAllChanges()
                .Subscribe(x =>
                {
                    var temp = optionsMonitor.CurrentValue.BedroomTemp;
                    var stateChanged = new WindowStateChanged()
                    {
                        EntityId = x.Entity.EntityId,
                        NewEntityState = x.New,
                        OldEntityState = x.Old,
                    };
                    mediator.Publish(stateChanged);
                });
        }
        catch (Exception ex)
        {
            logger.LogCritical(ex, "Error starting {AppName}", nameof(BedroomWindowSensorApp));
        }
    }
}
