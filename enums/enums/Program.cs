using System;

namespace enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
  
            var genre = GetValidMovieGenre();
            
            var movie = new Movie("Friday the 13th", genre);


            switch (movie.Genre)
            {
                case MovieGenre.Horror:
                    {
                        Console.WriteLine("OOOOooo Spoooky");
                        break;
                    }       
                case MovieGenre.Comedy:
                    {
                        Console.WriteLine("haha funny");
                        break;
                    }
                case MovieGenre.Action:
                    {
                        Console.WriteLine("my heart can't take it!! such a rush!");
                        break;
                    }
                case MovieGenre.Romance:
                    {
                        Console.WriteLine("ooooo... ;)");
                        break;
                    }
                case MovieGenre.Scifi:
                    {
                        Console.WriteLine("pew pew!");
                        break;
                    }
            }

            // simply doing this so my program does not end
            Console.ReadLine();
        }

        static MovieGenre GetValidMovieGenre()
        {
            while (true)
            {
                Console.WriteLine("Hey, please enter a valid movie genre!");
                if (Movie.TryGetGenre(Console.ReadLine(), out var genre))
                {
                    return genre;
                }

                Console.WriteLine("Invalid input");
            }
        }
    }
}
