using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemmsenHA.Core.NotificationMessages
{
    public class BaseEntityStateChanged : INotification
    {
        public string EntityId { get; set; }
    }
}
