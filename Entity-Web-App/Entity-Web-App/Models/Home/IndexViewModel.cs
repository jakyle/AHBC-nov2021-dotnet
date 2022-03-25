using Entity_Web_App.Services.DALModels;
using System.Collections.Generic;

namespace Entity_Web_App.Models.Home
{
    public class IndexViewModel
    {
        public IEnumerable<Services.DALModels.Student> Students { get; set; }
    }
}
