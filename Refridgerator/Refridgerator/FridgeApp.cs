using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refridgerator
{
    internal class FridgeApp
    {
        public static void Run()
        {
            try
            {
                var fridge = new Fridge();
                fridge.StoreFood(new Turkey(DateTime.Now.AddDays(-5), 20, "Turkey"));
                fridge.StoreFood(new Milk(DateTime.Now.AddDays(5), 1, "Milk"));

                if (fridge.TryGetFood("Milk", out var food))
                {
                    Console.WriteLine("Now I can haz strong bones");
                }

                if (fridge.TryCheckDate("Turkey", out var expirationDate) && expirationDate > DateTime.Now)
                {
                    Console.WriteLine("I'm gonna eat this guy...");
                }
                else
                {
                    Console.WriteLine("Oh noes... throw that foodz out :(");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("oh noes, your fridge is running... bet go catch it... heh");
            }
        }
    }
}
