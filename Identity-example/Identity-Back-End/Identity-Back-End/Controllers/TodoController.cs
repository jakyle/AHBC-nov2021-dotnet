using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;

namespace Identity_Back_End.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly UserContext _userContext;

        public TodoController(UserContext userContext)
        {
            _userContext = userContext;
        }

        [HttpGet]
        [Route("{userId}")]
        public async Task<IActionResult> GetTodos([FromRoute] int userId)
        {
            if (_userContext.IsLoggedIn(userId))
            {
                var user = await _userContext.GetUser(userId);


                // logic to grab a todo item
                return Ok(user.Todos);
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpGet]
        [Route("{userId}/{todoId}")]
        public async Task<IActionResult> GetTodos([FromRoute] int userId, [FromRoute] int todoId)
        {
            if (_userContext.IsLoggedIn(userId))
            {
                var todo = (await _userContext.GetUser(userId))
                    .Todos
                    .FirstOrDefault(todo => todo.Id == todoId);


                // logic to grab a todo item
                return Ok(todo);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
