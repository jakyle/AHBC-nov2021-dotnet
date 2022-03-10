using Microsoft.AspNetCore.Mvc;

namespace intro_to_mvc_for_real_this_time.Controllers
{
    public class PortfolioController : Controller
    {
        // somesite/portfolio/index


        public IActionResult Index()
        {
            return View();
        }
    }
}
