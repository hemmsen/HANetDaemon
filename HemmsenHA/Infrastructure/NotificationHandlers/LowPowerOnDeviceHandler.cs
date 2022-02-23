using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemmsenHA.Infrastructure.NotificationHandlers
{
    public class LowPowerOnDeviceHandler : INotificationHandler<LowPowerOnDevice>
    {
        private IMediator mediator;
        private IEntities entities;
        private IHaContext haContext;

        public LowPowerOnDeviceHandler(IHaContext haContext)
        {
            entities = new Entities(haContext);
            this.haContext = haContext;
        }
        public Task Handle(LowPowerOnDevice notification, CancellationToken cancellationToken)
        {
            var speakerNotification = new SpeakerNotification()
            {
                EntityId = entities.MediaPlayer.TvStue.EntityId,
                NotificationMessage = $"Strøm niveau på {new Entity<MediaPlayerAttributes>(haContext, notification.EntityId)?.Attributes?.FriendlyName}. Sæt den venligst til at lade"
            };

            mediator.Publish(speakerNotification);
            return Task.CompletedTask;
        }
    }
}
