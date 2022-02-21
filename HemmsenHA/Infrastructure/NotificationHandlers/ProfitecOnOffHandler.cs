using daemonapp.Messages;
using HomeAssistantGenerated;
using MediatR;
using NetDaemon.HassModel.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace daemonapp.Handlers
{
    public class ProfitecOnOffHandler : INotificationHandler<ProfitecStateChanged>
    {
        private readonly Entities _entities;
        private readonly Services _services;
        public ProfitecOnOffHandler(IHaContext haContext)
        {
            _entities = new Entities(haContext);
            _services = new Services(haContext);
        }
        public Task Handle(ProfitecStateChanged notification, CancellationToken cancellationToken)
        {
            if(notification.NewState.IsOff() && notification.OldState.IsOn())
            {
                _services.InputBoolean.TurnOff(ServiceTarget.FromEntity(_entities.InputBoolean.Profitecready.EntityId)); 
            }
            return Task.CompletedTask;
        }
    }
}
