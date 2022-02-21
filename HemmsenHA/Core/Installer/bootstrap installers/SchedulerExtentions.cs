using NetDaemon.Extensions.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daemonapp.Core
{
    public static class SchedulerExtentions
    {
        public static IDisposable RunDaily(this INetDaemonScheduler scheduler, TimeSpan timeOfDay, Action action)
        {
            var startTime = scheduler.Now.Date.Add(timeOfDay);
            if (scheduler.Now > startTime)
            {
                startTime = startTime.AddDays(1);
            }
            return scheduler.RunEvery(TimeSpan.FromDays(1), startTime, action);
        }
    }
}
