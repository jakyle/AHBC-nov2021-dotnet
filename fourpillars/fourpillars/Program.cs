using System;

namespace fourpillars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Animal animal = new Animal("James");
            animal.MakeNoise("sup");

            Cat oreo = new Cat("Oreo");
            string catNoise = oreo.MakeNoise();
            Console.WriteLine(catNoise);

            Tabby tabbyCat = new Tabby("Frank");
            Console.WriteLine(tabbyCat.Name);

        }
    }
}
