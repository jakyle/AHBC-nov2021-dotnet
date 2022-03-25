using http_intro.Services.ApiModels.StarWars;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace http_intro.Services
{
    public interface IStarWarsClient
    {
        Task<PlanetsResponse> GetPlanets();
    }


    // we create our OWN ABSTRACTION for calling a SPECIFIC API
    public class StarWarsClient : IStarWarsClient
    {
        // for any service you are integrating with via HTTP request,
        // you will create your own client that takes in an HTTPClient
        // as a depenceny in your client.
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public StarWarsClient(HttpClient client, IOptions<StarWarsClientConfig> config)
        {
            _httpClient = client;
            _baseUrl = config.Value.BaseUrl;
        }

        public async Task<PlanetsResponse> GetPlanets()
        {

            // when you make an http request, you ONLY have to put in the rest of the end
            // point, it will be automatically appended to the BAseURL that was setup
            // in your appsettings.json
            var httpResponseMessage = await _httpClient.GetAsync("planets");

            // the await keyword will WAIT for the TASK to complete, and return
            // the value that the Task was "fetching".
            var content = await httpResponseMessage.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<PlanetsResponse>(content);

            return response;

        }
    }



}
