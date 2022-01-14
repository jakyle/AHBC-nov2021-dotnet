using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_classroom_example
{
    public static class RoomCalcApplication
    {
        public static void Run()
        {
            try
            {
                // create a classroom that has a name, length, and width,
                // and output it's Area, Volume

                Validator validator = new Validator();

                int[] roomDim = (new []{ "length", "width", "height" })
                    .Select(x => validator.GetValidIntFromUser(GetValidMessage(x)))
                    .ToArray();

                RoomCalculator roomCalc = new RoomCalculator(roomDim[0], roomDim[1], roomDim[2]);

                Console.WriteLine($"the area of the room is: {roomCalc.Area}");
                Console.WriteLine($"the volume of the room is: {roomCalc.Volume}");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        private static string GetValidMessage(string measurement)
        {
            return $"Please enter a valid positive whole number for the {measurement} of yoru room";
        }
    }
}
