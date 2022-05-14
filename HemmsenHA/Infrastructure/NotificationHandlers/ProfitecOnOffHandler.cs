namespace daemonapp.Handlers;
public class ProfitecOnOffHandler : INotificationHandler<ProfitecStateChanged>
{
    private readonly Entities _entities;
    private readonly Services _services;
    private readonly IScheduler _scheduler;
    public ProfitecOnOffHandler(IHaContext haContext, IScheduler scheduler)
    {
        _entities = new Entities(haContext);
        _services = new Services(haContext);
        _scheduler = scheduler;
    }
    public Task Handle(ProfitecStateChanged notification, CancellationToken cancellationToken)
    {
        if (notification.NewState.IsOff() && notification.OldState.IsOn())
        {
            _services.InputBoolean.TurnOff(ServiceTarget.FromEntity(_entities.InputBoolean.Profitecready.EntityId));
            _scheduler.Schedule(TimeSpan.FromHours(1), x =>
            {
                if (_entities.Switch.KaffemaskineOnOff.IsOn())
                {
                    _services.Switch.TurnOff(ServiceTarget.FromEntity(_entities.Switch.KaffemaskineOnOff.EntityId));
                }
            });
        }
        return Task.CompletedTask;
    }
}