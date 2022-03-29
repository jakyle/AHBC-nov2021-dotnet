using System.Collections.Generic;

namespace Entity_Web_App.Models.Animal
{
    public class ViewAnimalsViewModel
    {
        public IEnumerable<Services.DALModels.Animal> Animals { get; set; }
    }
}
