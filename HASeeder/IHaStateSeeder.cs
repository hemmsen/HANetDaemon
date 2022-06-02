using System.Threading;
using System.Threading.Tasks;

namespace HASeeder;

public interface IHaStateSeeder
{
    Task ExecuteAsync(CancellationToken stoppingToken);
}