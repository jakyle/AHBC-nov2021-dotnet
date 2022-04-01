using Microsoft.AspNetCore.Mvc;

namespace intro_web_api.Controllers
{
    [ApiController] // ApiController is needed in order to self document using swagger
    [Route("[controller]")] // you need a route so your application will know how to reach this
    // controller
    public class HelloController : ControllerBase // web api controller inherits from ControllerBase
    {
        // when adding routes to your actions, You can share the exact same route NAME, as long as
        // you are using a DIFFERENT HTTP Method. (GET, POST, PUT, DELETE)

        // http get for GETTING existing data
        [HttpGet] // your http method is needed so you know which method to use (GET, POT, PUT, etc) 
        // access this 
        [Route("World/planet")]
        public string Get()
        {
            return "Hello World!";
        }


        // http POSt for ADDING NEW DATA
        [HttpPost] // your http method is needed so you know which method to use (GET, POT, PUT, etc) 
        // access this 
        [Route("World")]
        public string SendMeDaData(string message)
        {
            return message;
        }


        [HttpGet] 
        // localhost:5001/Hello/2
        [Route("{id}")] // route parameter, a way to take DATA into the route
        public string GetAnimalName(int id)
        {
            var animals = new string[] { "Dog", "Cat", "Mouse" };

            return animals[id];
        }


        // there are TWO ways to CAPTURE data from your route
        // 1. Route Parameters
        // 2. query parameters
        [HttpGet]
        // localhost:5001/Hello/2/mouse Route parameters are required data to be passed into the url
        // localhost:5001/Hello/2/mouse?age=4&sign=virgo, Query parameters SHOULD be optional
        [Route("{id}/{name}")] // route parameter, a way to take DATA into the route
        public string GetAnimalName([FromRoute] int id, [FromRoute] string name, [FromQuery] int? age, [FromQuery] string sign)
        {
            var animals = new string[] { "Dog", "Cat", "Mouse" };

            if (age != null && sign != null)
            {
                return $"name: {name}, type: {animals[id]}, age: {age.Value}, sign: {sign}";
            }

            return $"name: {name}, type: {animals[id]}";
        }




        // the HTTP METHOD you CHOOSE is  NOT a limiting factor on how you CAPTURE DATA from your http request



        // In order to recieve data as JSON, I recommend you decorate your parameter with a 
        // FromBody attribute, that will tell the framework that the data is coming from the HTTP
        // Body portion of the request.  which by default, will accpet as JSON
        [HttpPost]
        [Route("animal")]
        public IActionResult PostAnimal([FromBody] AnimalRequest animal)
        {

            // You CAN return of type IActionResult just like MVC and the View() Method, in an api
            // application, you return the desired status code, and you pass in the data response
            // as an argument.
            // https://developer.mozilla.org/en-US/docs/Web/HTTP/Status for a list of all official status codes
            return Ok(animal);
        }
    }
}
