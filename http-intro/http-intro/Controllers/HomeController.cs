using http_intro.Models;
using http_intro.Models.Home;
using http_intro.Services;
using http_intro.Services.ApiModels.StarWars;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace http_intro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStarWarsClient _client;


        // Using dependency injection, we are able to acces our StarWars CLient INterface / contract
        public HomeController(ILogger<HomeController> logger, IStarWarsClient client)
        {
            _logger = logger;
            _client = client;
        }

        public async Task<IActionResult> Index()
        {
            PlanetsResponse planets = await _client.GetPlanets();
            var viewModel = new IndexViewModel();

            viewModel.PlanetNames = planets.results
                .Select(planet => planet.name)
                .ToList();

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
