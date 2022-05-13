using Identity_Back_End.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace Identity_Back_End
{
    public class GitHubService
    {
        private readonly GithubOAuthSettings _config;
        private readonly HttpClient _httpClient;

        public GitHubService(HttpClient httpClient, IOptions<GithubOAuthSettings> config)
        {
            _config = config.Value;
            _httpClient = httpClient;
        }

        public async Task<GithubToken> GetToken(string code)
        {
            var httpParams = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                { "code", code },
                { "redirect_uri", _config.RedirectUri },
                { "client_id", _config.ClientId },
                { "client_secret", _config.ClientSecret },
            });

            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri("https://github.com/login/oauth/access_token"),
                Method = HttpMethod.Post,
                Content = httpParams
            };

            request.Headers.Add("Accept", "application/json");

            var response = await _httpClient.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            GithubToken token = JsonSerializer.Deserialize<GithubToken>(content, options);
            return token;
        }

        public async Task<GithubUser> GetGithubUser(string token)
        {

            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri("https://api.github.com/user"),
                Method = HttpMethod.Get,
            };

            request.Headers.Add("Authorization", $"token {token}");
            request.Headers.Add("User-Agent", _config.UserAgent);
            //User - Agent: Awesome - Octocat - App

            var response = await _httpClient.SendAsync(request);

            // if we get a non successful status code from sending in a token to Github, that means
            // the token is bad, and the user is not logged in with your application using github,
            // therefore we cannot return a GitHub user.
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var content = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var githubUser = JsonSerializer.Deserialize<GithubUser>(content, options);

            return githubUser;
        }
    }
}
