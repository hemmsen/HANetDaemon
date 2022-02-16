using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace daemonapp.Core
{
    public interface IInstallerActions
    {
        void Install(IServiceCollection services);
    }
}
