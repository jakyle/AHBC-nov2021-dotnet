using System;
using System.Collections.Generic;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mammal james = new Human();

            james.Name = "James";



            IStartEngine chevySonic = new Car();

            chevySonic.StartEngine("my key");

            List<IStartEngine> engines = new List<IStartEngine>();
            engines.Add(chevySonic);
            engines.Add(new Truck());
        }


        void StartEngines(IEnumerable<IStartEngine> engines)
        {
            foreach (IStartEngine engine in engines)
            {
                engine.StartEngine("some key...");
            }
        }
    }
}
