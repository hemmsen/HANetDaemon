using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daemonapp.Messages
{
    public class NetatmoOutdoorMeasurementChanged : INotification
    {
        public double CurrentTemperature { get; set; }
        public double OldTemperature { get; set; }
    }
}
