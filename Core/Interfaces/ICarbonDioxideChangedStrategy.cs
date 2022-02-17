using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemmsenHA.Core.Interfaces
{
    public interface ICarbonDioxideChangedStrategy
    {
        bool CanHandle(CarbonDioxideChanged carbonDioxideChanged);
        Task DoAction(CarbonDioxideChanged carbonDioxideChanged);
    }
}
