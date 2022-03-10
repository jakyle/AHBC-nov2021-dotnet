using intro_to_mvc_for_real_this_time.Models.Dog;
using Microsoft.AspNetCore.Mvc;

namespace intro_to_mvc_for_real_this_time.Controllers
{
    public class DogController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexViewModel("Index", "The Index Page!");
            return View(model);
        }

        public IActionResult Cat()
        {
            return View();
        }
    }
}
