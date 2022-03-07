using NetDaemon.Client;
using System.Net.Http;
using System.Text.Json;

namespace HemmsenHA.Infrastructure.Configuration;
public class HaConfigurationProvider : ConfigurationProvider
{
    private HttpClient client;
    public HaConfigurationProvider(HttpClient client)
    {
        this.client = client;
        var timer = new Timer(x => Load(), null, new TimeSpan(0, 1, 0), new TimeSpan(0, 1, 0));
    }
    public override void Load()
    {
        var data = client.GetAsync("states").GetAwaiter().GetResult();
        var count = data.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        var options = JsonSerializer.Deserialize<List<HaOptions>>(count);
        var configOptions = options.Where(x => x.entity_id.Contains("config_")).ToList();
        Log.Logger.Information("Loading {numberOfConfig} runtime configurations from HA", configOptions.Count);
        Log.Logger.Information("First config entityId {entityId} and state {state}", configOptions.First().entity_id, configOptions.First().state);
        Data = configOptions.ToDictionary(x =>x.attributes.friendly_name, x => x.state);
    }
}

public class HaOptions
{
    public string entity_id { get; set; }
    public string state { get; set; }

    public StateAttributes attributes { get; set; }
}

public class StateAttributes
{
    public string friendly_name { get; set; }
}