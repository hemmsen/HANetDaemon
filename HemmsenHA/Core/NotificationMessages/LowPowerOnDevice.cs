using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemmsenHA.Core.NotificationMessages
{
    public class LowPowerOnDevice : BaseEntityStateChanged, INotification
    {
        public double? PowerLevel { get; set; }
    }
}
