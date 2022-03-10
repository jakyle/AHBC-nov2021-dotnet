using intro_to_mvc_for_real_this_time.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace intro_to_mvc_for_real_this_time.Controllers
{

    // https://localhost:5001/Home
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //     controller name -> vvv   vvv  <- Action name
        // https://localhost:5001/Home/Index
        public IActionResult Index()
        { 
            return View();
        }

        // https://localhost:5001/Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // https://localhost:5001/Home/About
        public IActionResult About()
        {
            return View();
        }

        // https://localhost:5001/Home/Error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
