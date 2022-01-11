using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_classroom_example
{
    public class Validator
    {
        public int GetValidIntFromUser(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                if (int.TryParse(Console.ReadLine(), out int result) && result > 0)
                {
                    return result;
                }

                Console.WriteLine("invalid input, try again");
            }
        }

        public double GetValidDoubleFromUser(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                if (double.TryParse(Console.ReadLine(), out double result) && result > 0)
                {
                    return result;
                }

                Console.WriteLine("invalid input, try again");
            }
        }
    }
}
