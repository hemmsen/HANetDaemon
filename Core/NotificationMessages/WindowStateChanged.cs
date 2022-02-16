using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemmsenHA.Core.NotificationMessages
{
    public class WindowStateChanged : BaseEntityStateChanged
    {
        public DateTime StateChangedAt { get; set; } = DateTime.Now;
        public EntityState<BinarySensorAttributes> NewState { get; set; }
        public EntityState<BinarySensorAttributes> OldState { get; set; }
    }
}   
