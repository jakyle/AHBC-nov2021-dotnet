using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace intro_web_api.Controllers
{
    [ApiController] // these two attributes ARE REQUIRED
    [Route("[controller]")]
    public class DogController : ControllerBase
    {
        private readonly List<string> _dogs;

        public DogController()
        {
            _dogs = new List<string>()
            {
                "Coco", 
                "Browney"
            };
        }
        // localhost:5001/dog
        [HttpGet]
        public List<string> GetDogs()
        {
            return _dogs;
        }

        // localhost:5001/1
        [Route("{index}")]
        public IActionResult GetDog([FromRoute] int index)
        {
            if (_dogs.Count < index && index >= 0)
            {
                return Ok(_dogs[index]);
            }

            return NotFound();
        }
    }
}
