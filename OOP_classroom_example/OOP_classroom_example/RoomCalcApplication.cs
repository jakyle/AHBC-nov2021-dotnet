using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_classroom_example
{
    public class RoomCalcApplication
    {
        public void Run()
        {
            // create a classroom that has a name, length, and width,
            // and output it's Area, Volume

            Validator validator = new Validator();
            int length = validator.GetValidIntFromUser(GetValidMessage("length"));
            int width = validator.GetValidIntFromUser(GetValidMessage("width"));
            int height = validator.GetValidIntFromUser(GetValidMessage("height"));

            RoomCalculator roomCalc = new RoomCalculator(length, width, height);

            Console.WriteLine($"the area of the room is: {roomCalc.Area}");
            Console.WriteLine($"the volume of the room is: {roomCalc.Volume}");

            Console.ReadLine();
        }

        private string GetValidMessage(string measurement)
        {
            return $"Please enter a valid positive whole number for the {measurement} of yoru room";
        }
    }
}
