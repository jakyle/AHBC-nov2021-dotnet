using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Identity_Back_End.Models
{
    public class GithubToken
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        public string Scope { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }
    }
}
