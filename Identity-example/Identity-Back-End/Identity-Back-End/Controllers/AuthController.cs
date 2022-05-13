using Identity_Back_End.Models;
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
        private readonly UserContext _userContext;

        public AuthController(UserContext userContext, GitHubService gitHubService)
        {
            _gitHubService = gitHubService;
            _userContext = userContext;
        }

        [HttpGet]
        [Route("login/{code}/{authority}")]
        public async Task<IActionResult> Login([FromRoute] string code, [FromRoute] Authority authority)
        {
            var token = authority switch
            {
                Authority.Github => await _gitHubService.GetToken(code),
            };

            var githubUser = await _gitHubService.GetGithubUser(token.AccessToken);

            if (githubUser == null)
            {
                return Unauthorized();
            }

            // this is YOUR application DATABASE
            var user = await _userContext.UpsertGithubUser(githubUser, token.AccessToken);

            return Ok(user);
        }

        [HttpGet]
        [Route("auto-login/{userId}")]
        public async Task<IActionResult> AutoLogin([FromRoute] int userId)
        {
            var user = await _userContext.GetUser(userId);

            if (user == null)
            {
                return NotFound();
            }

            var githubUser = await _gitHubService.GetGithubUser(user.Token);

            if (githubUser == null)
            {
                // null out the token in our application database for that specific user
                // this is how we treat the user as NOT being logged in.
                await _userContext.UpdateUserToken(userId, null);
                return Unauthorized();
            }

            return Ok(user);
        }

        [HttpGet]
        [Route("logout/{userId}")]
        public async Task<IActionResult> Logout(int userId)
        {
            await _userContext.Logout(userId);
            return Ok();
        }
    }
}
