using System;
using System.Collections.Generic;

namespace OopQuickReview
{
    internal class Program
    {
        static void Main(string[] args)
        {


            

            var oreo = new Animal(7, "Oreo");

            oreo.GetAgeMessage();

            var animals = new List<Animal>();
            animals.Add(new Animal(2, "James"));
            animals.Add(new Animal(1, "Brownie"));
            animals.Add(new Animal(2, "Coco"));

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);  
            }

        }
    }
}
