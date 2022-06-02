using System.Threading;
using System.Threading.Tasks;
using HASeeder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
public class Program
{
    private static async Task Main(string[] args)
    {
        //setup our DI
        var serviceProvider = new ServiceCollection()
            .AddLogging(x => x.AddConsole().SetMinimumLevel(LogLevel.Debug))
            .AddSingleton<IHaStateSeeder, HAStateSeeder>()
            .AddHttpClient()
            .BuildServiceProvider();

        var logger = serviceProvider.GetService<ILoggerFactory>()
            .CreateLogger<Program>();
        logger.LogDebug("Starting application");

        CancellationTokenSource source = new CancellationTokenSource();
        CancellationToken token = source.Token;
        await serviceProvider.GetRequiredService<IHaStateSeeder>().ExecuteAsync(token);
    }
}