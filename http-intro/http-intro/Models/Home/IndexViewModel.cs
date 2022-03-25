using http_intro.Services.ApiModels.StarWars;
using System.Collections.Generic;

namespace http_intro.Models.Home
{
    public class IndexViewModel
    {
        public IEnumerable<string> PlanetNames { get; set; }
    }
}
