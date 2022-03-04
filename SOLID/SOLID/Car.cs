using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{

    // Single Responsibility, which is the S in the S.O.L.I.D principles.
    // your class or abstraction, or even methods should have ONE responsibility, ie.
    // it does that ONE thing and that ONE thing only.  if you find that your class is solving
    // for multiple problems, break that class apart into two two new classes.
    public class Car
    {
        void Drive()
        {
            // car will drive
        }   

        void Park()
        {

        }
        
        // this get direction, although it helps with Driving to your destination, one could
        // make an argument that the CAR itself is not getting the directions, your gps or 
        // phone is getting the direction, therefore, this method COULD be violating Single 
        // responsibility.
        void GetDirection()
        {

        }
    }

    public class GPS
    {
        void GetDirection()
        {

        }
    }

}
