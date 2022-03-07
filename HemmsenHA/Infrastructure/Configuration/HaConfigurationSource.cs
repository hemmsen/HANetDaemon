using System.Net.Http;

namespace HemmsenHA.Infrastructure.Configuration;
public class HaConfigurationSource : IConfigurationSource
{
    private HttpClient client;
    public HaConfigurationSource(string token, string baseUrl)
    {
        client = new HttpClient()
        {
            BaseAddress = new Uri(baseUrl)
        };
        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
    }
    public IConfigurationProvider Build(IConfigurationBuilder builder)
    {
        return new HaConfigurationProvider(client);
    }
}