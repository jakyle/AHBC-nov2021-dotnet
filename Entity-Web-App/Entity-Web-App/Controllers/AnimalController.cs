using Entity_Web_App.Models.Animal;
using Entity_Web_App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Entity_Web_App.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AnimalContext _animalContext;

        public AnimalController(AnimalContext context)
        {
            _animalContext = context;
        }


        public IActionResult ViewAnimals()
        {
            var model = new ViewAnimalsViewModel();
            model.Animals = _animalContext.Animals;
            return View(model);
        }

        // all actions are [HttpGet] by default
        public IActionResult AddAnimal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnimal(AddAnimalViewModel model)
        {
            _animalContext.Add(model.Animal);
            _animalContext.SaveChanges();
            return RedirectToAction(nameof(ViewAnimals));
        }
    }
}
