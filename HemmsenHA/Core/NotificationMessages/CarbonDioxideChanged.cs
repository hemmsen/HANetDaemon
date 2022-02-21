using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemmsenHA.Core.NotificationMessages
{
    public class CarbonDioxideChanged : BaseEntityStateChanged
    {
        public NumericEntityState<NumericSensorAttributes> NewCarbonDioxide { get; set; }
        public NumericEntityState<NumericSensorAttributes> OldCarbonDioxide { get; set; }
        public DateTime MeasuredAt { get; set; } = DateTime.Now;
    }
}
