namespace HemmsenHA.Infrastructure.Strategies.Window;
public class ClosedWindowEvaStrategy : IWindowStateChangedStrategy
{
    private Entities entities;
    private IServices services;
    private IScheduler scheduler;
    private IMediator mediator;
    public ClosedWindowEvaStrategy(IHaContext haContext, IScheduler scheduler, IMediator mediator)
    {
        entities = new Entities(haContext);
        this.scheduler = scheduler;
        this.mediator = mediator;
        this.services = new Services(haContext);
    }
    public bool CanHandle(WindowStateChanged windowStateChanged)
    {
        return windowStateChanged.EntityId == entities.BinarySensor.LumiLumiSensorMagnetAq261992507OnOff.EntityId && windowStateChanged.NewEntityState.IsOff();
    }

    public Task DoAction(WindowStateChanged windowStateChanged)
    {
        if (DateTimeOffset.Now.TimeOfDay < TimeSpan.FromHours(18))
        {
            scheduler.Schedule(TimeSpan.FromMinutes(30), () =>
            {
                services.Climate.SetHvacMode(ServiceTarget.FromEntity(entities.Climate.NetatmoEva.EntityId), "auto");

            });
        }
        else
        {
            services.Climate.SetHvacMode(ServiceTarget.FromEntity(entities.Climate.NetatmoEva.EntityId), "auto");
        }
        return Task.CompletedTask;
    }
}