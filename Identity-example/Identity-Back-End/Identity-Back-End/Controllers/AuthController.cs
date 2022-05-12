using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_Back_End.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly GitHubService _gitHubService;

        public AuthController(GitHubService gitHubService)
        {
            _gitHubService = gitHubService;
        }

        [HttpGet]
        [Route("{code}")]
        public async Task<IActionResult> GetUser([FromRoute] string code)
        {
            var token = await _gitHubService.GetToken(code);
            var user = await _gitHubService.GetGithubUser(token.AccessToken);
            return Ok(user);
        }
    }
}
