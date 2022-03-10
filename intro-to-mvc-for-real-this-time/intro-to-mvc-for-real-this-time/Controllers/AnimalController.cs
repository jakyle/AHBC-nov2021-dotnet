using intro_to_mvc_for_real_this_time.Models.Animal;
using Microsoft.AspNetCore.Mvc;

namespace intro_to_mvc_for_real_this_time.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult Cat()
        {
            var model = new CatViewModel();
            model.Title = "cat";
            model.Header = "domesticated mammal";
            model.Description = "cat, (Felis catus), also called house cat or domestic cat, domesticated member of the family Felidae, order Carnivora, and the smallest member of that family. Like all felids, domestic cats are characterized by supple low-slung bodies, finely molded heads, long tails that aid in balance, and specialized teeth and claws that adapt them admirably to a life of active hunting. Cats possess other features of their wild relatives in being basically carnivorous, remarkably agile and powerful, and finely coordinated in movement.";
            return View(model);
        }
    }
}
