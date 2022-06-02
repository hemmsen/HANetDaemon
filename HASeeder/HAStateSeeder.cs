using System.Net.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net;

namespace HASeeder;

public class HAStateSeeder : IHaStateSeeder
{
    private readonly ILogger<HAStateSeeder> _logger;
    private readonly IHttpClientFactory _clientFactory;

    public HAStateSeeder(ILogger<HAStateSeeder> logger, IHttpClientFactory clientFactory)
    {
        _logger = logger;
        _clientFactory = clientFactory;
    }

    public async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        var text = File.ReadAllText($"../data/hastates/homeassistant.states.json");
        var states = JsonSerializer.Deserialize<List<HaState>>(text);
        _logger.LogInformation("Number of objects {numberofobjects}", states.Count);
        var client = _clientFactory.CreateClient();
        client.BaseAddress = new Uri("http://homeassistant:8123/api/");
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiI4M2Y5Mjk5MDRmNTM0ODhmYTFiMDcyMDExOTIzZWYzYiIsImlhdCI6MTY1MzQ3OTEwNSwiZXhwIjoxOTY4ODM5MTA1fQ.GGCI2YWfZV5koP4B-BgK5a7x5kIqGE2xW-TthehDYNk");

        //Wait for HA Api to be ready
        var pingRes = HttpStatusCode.NotFound;
        while (pingRes != HttpStatusCode.OK)
        {
            try
            {
                _logger.LogInformation("ping not 200 ok!");
                pingRes = (await client.GetAsync("states")).StatusCode;
            }
            catch (HttpRequestException)
            {
                await Task.Delay(500);
            }

        }

        for (int i = 0; i < states.Count; i++)
        {
            {
                var state = states[i];
                var res = await client.PostAsync($"states/{state.entity_id}", new StringContent(JsonSerializer.Serialize(state)));
                if (res.IsSuccessStatusCode)
                {
                    _logger.LogInformation("Success!!");
                }
                else
                {
                    _logger.LogError("Statuscode: {statucode}", res.StatusCode);
                }
            }
        }
        _logger.LogInformation("Initializing done!");
    }
}