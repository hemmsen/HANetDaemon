using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemmsenHA.Core.Interfaces
{
    public interface IWindowStateChangedStrategy
    {
        bool CanHandle(WindowStateChanged windowStateChanged);

        Task DoAction(WindowStateChanged windowStateChanged);
    }
}
