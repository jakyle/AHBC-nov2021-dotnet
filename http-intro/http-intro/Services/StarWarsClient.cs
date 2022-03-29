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

            // you only need to set a base url if you are NOT setting up the base url in 
            // startup.cs
            _baseUrl = config.Value.BaseUrl;
        }

        public async Task<PlanetsResponse> GetPlanets()
        {

            // when you make an http request, you ONLY have to put in the rest of the end
            // point, it will be automatically appended to the BAseURL that was setup
            // in your appsettings.json
            HttpResponseMessage httpResponseMessage =  await _httpClient.GetAsync("planets");
            
            // the typical steps when writing an async method
            // 1. you don't make it async until you need to.
            // 2. the moment YOU are calling a method that returns a Task or Task<something>, you 
            // then use the await keyword to resolve or wait for that task to complete.
            // 3. you then use the async method modifier to make your method async
            // 4. you change your return type to be a TAsk. if your method is void => Task
            // if your method is returning an actual type, it becomes Task<yourtype>
            // 5. any method that is calling your now async method, ALSO needs to be turned async

            // the await keyword will WAIT for the TASK to complete, and return
            // the value that the Task was "fetching".
            var content = await httpResponseMessage.Content.ReadAsStreamAsync();
            var response = await JsonSerializer.DeserializeAsync<PlanetsResponse>(content);

            return response;
        }
    }



}
