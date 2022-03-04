namespace HemmsenHA.Infrastructure.Strategies.Window;
public class OpenWindowEvaStrategy : IWindowStateChangedStrategy
{
    private Entities entities;
    private IServices services;
    private IScheduler scheduler;
    private IMediator mediator;
    public OpenWindowEvaStrategy(IHaContext haContext, IScheduler scheduler, IMediator mediator)
    {
        entities = new Entities(haContext);
        this.scheduler = scheduler;
        this.mediator = mediator;
        this.services = new Services(haContext);
    }
    public bool CanHandle(WindowStateChanged windowStateChanged)
    {
        return windowStateChanged.EntityId == entities.BinarySensor.LumiLumiSensorMagnetAq261992507OnOff.EntityId;
    }

    public Task DoAction(WindowStateChanged windowStateChanged)
    {
        if (windowStateChanged.NewEntityState.IsOn())
        {
            services.Climate.SetTemperature(ServiceTarget.FromEntity(entities.Climate.NetatmoEva.EntityId), 8.0);
            return Task.CompletedTask;
        }
        services.Climate.SetHvacMode(ServiceTarget.FromEntity(entities.Climate.NetatmoEva.EntityId), "auto");
        return Task.CompletedTask;
    }
}