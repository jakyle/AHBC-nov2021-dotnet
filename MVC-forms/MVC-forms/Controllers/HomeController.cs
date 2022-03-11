using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_forms.Models;
using MVC_forms.Models.Home;
using MVC_forms.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_forms.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Calculator _calculator;


        // Used Dependency injection that to ADD our Calculator depdency into
        // our controller.  the dependency is defined in Startup.cs in the ConfigureServices method.
        public HomeController(ILogger<HomeController> logger, Calculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult User(IndexViewModel inputViewModel)
        {
            var userViewModel = new UserViewModel(inputViewModel.User);

            return View(userViewModel);
        }

        public IActionResult Number(NumberViewModel numberViewModel)
        {
            // THis calculator data is DATA you can access via consecutive action calls
            // in other words, the data will always persist, as long as the application is running.
            _calculator.Total += numberViewModel.Number;
            numberViewModel.Total = _calculator.Total;
            return View(numberViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
