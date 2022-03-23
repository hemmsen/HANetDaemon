namespace daemonapp.Handlers
{
    public class VacumCleanHandler : INotificationHandler<VacuumClean>
    {
        private IServices _services;
        private IEntities _entities;
        private INetDaemonScheduler _scheduler;
        private IMediator _mediator;

        public VacumCleanHandler(IHaContext haContext, INetDaemonScheduler scheduler, IMediator mediator)
        {
            _services = new Services(haContext);
            _entities = new Entities(haContext);
            _scheduler = scheduler;
            _mediator = mediator;
        }

        public Task Handle(VacuumClean notification, CancellationToken cancellationToken)
        {
            if (_entities.InputBoolean.Skipnextvacuumcleanlivingroom.State.Equals("off"))
            {
                _services.XiaomiMiio.VacuumCleanSegment(ServiceTarget.FromEntity(_entities.Vacuum.RoborockS6Maxv.EntityId), notification.Segments);
                _services.Light.TurnOn(ServiceTarget.FromEntity(_entities.Light.LivingroomLights.EntityId));
                _services.Light.TurnOn(ServiceTarget.FromEntity(_entities.Light.KokkenSpotsLevelOnOff.EntityId));
                _services.Counter.Decrement(ServiceTarget.FromEntity(_entities.Counter.Dustbinemptycreditsleft.EntityId));
            }
            else
            {
                _services.InputBoolean.Toggle(ServiceTarget.FromEntity(_entities.InputBoolean.Skipnextvacuumcleanlivingroom.EntityId));
            }
            return Task.CompletedTask;
        }
    }
}
