using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_basics
{
    internal class Program
    {
        // Main is the entry point to any program, where a program is c# code
        // that can be executed or "ran"
        static void Main(string[] args)
        {
            // you create, or instantiate an object into memory by using
            // the "new" keyword
            Bottle bottleOne = new Bottle(); // a "unique" bottle object, you can
            // have many objects of the same type into memory.


            // you use "Dot" notation to access ANY PUBLIC MEMBER of that instance
            // object.
            Console.WriteLine(bottleOne.Volume);
            bottleOne.Volume = 32;
            bottleOne.FillBottle();
            // the dot between bottleOne and FillBottle(), is using
            // "DOT" notation to access the member FillBottle(), in this case
            // FillBottle() is a method

            Console.WriteLine(bottleOne.Volume);

            bottleOne.Color = "blue";
            Console.WriteLine(bottleOne.Color); // STRINGS are a reference type, but
            // BEHAVE like a value, ie, you COPY STRINGS, and you CANNOT modify 
            // strings, you will just make a new one


            List<string> names = bottleOne.Names;

            Bottle bottleTwo = new Bottle();
            bottleTwo.Volume = 16; // bottleTwo's Volume property is NOT the same as 
            // bottleOne's volume property.  
            bottleTwo.EmptyBottle();


            int x = 5;
            int y = 3;


            Hat hat = new Hat();
            Console.WriteLine(hat.Size);

            List<string> otherNames = new List<string>();

            Ball footBall = new Ball("foot ball");
            Console.WriteLine(footBall.SportType);

            // your defined class is A VALID TYPE
            List<Ball> balls = new List<Ball>();
            balls.Add(footBall);
            balls.Add(new Ball("soccer"));
            balls.Add(new Ball("tennis"));
            balls.Add(new Ball("sports"));
            balls.Add(new Ball("baseball"));

            // int x = 3 + (5 * (10 / 2));

            Console.WriteLine(PlayBall(balls.FirstOrDefault()));


            foreach (Ball ball in balls)
            {
                Console.WriteLine(ball);
            }

            // placing this here so my console does not close automatically
            Console.ReadLine();
        }

        private static string PlayBall(Ball ball)
        {
            return $"Lets play some {ball.SportType}";
        }
    }
}
