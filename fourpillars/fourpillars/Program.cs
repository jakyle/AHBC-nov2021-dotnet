using System;
using System.Collections.Generic;

namespace fourpillars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            string name = new string(new char[] { 'J', 'A', 'M', 'E', 'S' });



            Cat oreo = new Cat("Oreo");
            string catNoise = oreo.MakeNoise();
            Console.WriteLine(catNoise);


            Tabby tabbyCat = new Tabby("Frank");

            Console.WriteLine(tabbyCat.Name);

            Mouse jerry = new Mouse("Jerry");
            List<Animal> animals = new List<Animal>();
            animals.Add(tabbyCat);
            animals.Add(new Dog("Coco"));
            animals.Add(jerry);

            foreach (Animal animal in animals)
            {

                Console.WriteLine(animal.MakeNoise());
            }


            Console.WriteLine(jerry.Name);


            int result = GetNumberOfRepeatedLetters("James", 'a');
            int resultTwo = GetNumberOfRepeatedLetters(new List<char> { 'j', 'a', 'm', 'e', 's' }, 'a');
            int resultThree = GetNumberOfRepeatedLetters(new char[] { 'j', 'a', 'm', 'e', 's' }, 'a');

            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Sphere(20));
            shapes.Add(new Cube(20));

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }

        static int GetNumberOfRepeatedLetters(IEnumerable<char> letters, char letter)
        {

            int result = 0;
            foreach (char item in letters)
            {
                if (item == letter)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
