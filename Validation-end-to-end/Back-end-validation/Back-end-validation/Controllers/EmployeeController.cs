using Back_end_validation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Back_end_validation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostEmployee([FromBody] EmployeePost model)
        {
            if (ModelState.IsValid)
            {
                return Ok(model);
            }
            else
            {
                return BadRequest();
            }
            
        }
    }
}
