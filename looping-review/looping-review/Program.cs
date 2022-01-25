using System;
using System.Collections.Generic;

namespace looping_review
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var names = new List<string>();
            names.Add("James");
            names.Add("Coco");
            names.Add("Browny");

            var count = CountOfEvenNames(names);
        }

        public static int CountOfEvenNames(IEnumerable<string> names)
        {
            int count = 0;
            try
            {
                foreach (string name in names)
                {
                    if (name.Length % 2 == 0)
                    {
                        count++;
                    }
                }
                return count;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return count;            
        }

    }
}
