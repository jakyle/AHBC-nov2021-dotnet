using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    internal class Animal
    {
        public string Name { get; set; }

        // it's common practice to use an enum type as a property of a class / object
        // to help classify that "TYPE" of class / obect WITHOUT using inheritence, ie, you don't really
        // NEED to create a child class if you are ONLY creating a child class to determine it's
        // type.
        public AnimalFamily AnimalFamily { get; set; }


        public string MakeNoise()
        {
            return "rawr...";
        }
    }
}
