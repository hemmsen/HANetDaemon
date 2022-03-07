using Newtonsoft.Json;
using System.Net.Http;

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
        var options = JsonConvert.DeserializeObject<List<HaOptions>>(count);
        var configOptions = options.Where(x => x.EntityId.Contains("config_")).ToList();
        Data = configOptions.ToDictionary(x =>x.Attributes.Name, x => x.State);
    }
}

public class HaOptions
{
    [JsonProperty("entity_id")]
    public string EntityId { get; set; }
    [JsonProperty("state")]
    public string State { get; set; }

    [JsonProperty("attributes")]
    public StateAttributes Attributes { get; set; }
}

public class StateAttributes
{
    [JsonProperty("friendly_name")]
    public string Name { get; set; }
}