using System.Net.Http;

namespace HemmsenHA.Infrastructure.Configuration;
public class HaConfigurationSource : IConfigurationSource
{
    private HttpClient client;
    public HaConfigurationSource(string token, string baseUrl)
    {
        if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri(baseUrl)
            };
        }
        else
        {
            client = new HttpClient()
            {
                //We are inside supervisor container so url will always be the same !
                BaseAddress = new Uri("http://supervisor/core/api/")
            };
        }

        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
    }
    public IConfigurationProvider Build(IConfigurationBuilder builder)
    {
        return new HaConfigurationProvider(client);
    }
}