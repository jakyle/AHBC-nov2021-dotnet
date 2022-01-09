using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basics
{

    // Anytime you WRite a new class into a file... you are effectively creating a 
    // new TYPE in your code base.
    internal class Ball
    {
        // a constructor is the Method that gets called when you use the 
        // "new" keyword to create a new instance of an object
        // AT THE END OF THE DAY, a CONSTRUCTOR IS JUST A METHOD!!!!!!!!!!!!!!!@!
        // by setting parameters the classes constructor, YOU are requiring that when
        // this object gets created (constructed), that the parmeters of said contructor
        // are also required.
        public Ball(string sportType)
        {
            // constructors are commonly used to set the data that you are requiring
            // for your object to exist.
            SportType = sportType;
        }

        // auto properties "Hide" the backing field you would usually
        // MANUALLY set with your property.  so when you ASSIGN an AUTO PROPETY,
        // it will take in that data and auto assign a "field" that does not exist frankly.
        public string SportType { get; private set; }
    }
}
