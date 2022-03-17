using DI_Container_and_web.Models;
using DI_Container_and_web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DI_Container_and_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICalculator _calculator;


        // Dependancy injection is where we simply pass in our dependancy for our class via the contructor
        // (A dependancy is just another class that is solving a seperate problem that the DEPANDEE <HomeController> 
        // DEPENDS ON.)
        public HomeController(
            ILogger<HomeController> logger,
            ICalculator calculator,
            NoGoodService noGoodService)
        {
            _logger = logger;
            _calculator = calculator;
        }

        public IActionResult Index()
        {
            var sum = _calculator.Add(1, 2);
            return View();
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
