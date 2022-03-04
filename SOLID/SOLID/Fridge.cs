using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    
    // Open Closed Principle, Open for Extension, CLOSED for modifying
    public class Fridge
    {
        public IEnumerable<string> Foods { get;}

        public void SetTempature(double tempature)
        {
            // set the tempature of your food


            // write the logic to ALSO set the humidity level here... but plaese resist the urge
        }

        public void SetTempature(double tempature, double humidityLevel)
        {

        }

        // Open Closed Principle states that if you need to add more behavior to your class or abstraction
        // do not modify exsting behavior, sure you could add if statements or other logic in your existing
        // methods to help achieve your goal, but by doing so, you are adding unessary risk of breaking 
        // claasses that depend on that orignal behavior. if you need to add MORE behavior to an existing
        // class. simply add more members, ie EXTEND the class
        public void SetHumidity(double humidityLevel)
        {
            // some logic to set the humidity in the fridge
        }
    }
}
