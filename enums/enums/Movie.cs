using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    internal class Movie
    {
        public Movie(string name, MovieGenre movieGenre)
        {
            this.Name = name;
            this.Genre = movieGenre;
        }

        public string Name { get; set; }
        public MovieGenre Genre { get; set; }


        public static bool TryGetGenre(string input, out MovieGenre movieGenre)
        {
            switch (input.ToLower())
            {
                case "horror": 
                    {
                        movieGenre = MovieGenre.Horror;
                        return true;
                    }
                case "comedy":
                    {
                        movieGenre = MovieGenre.Comedy;
                        return true;
                    }
                case "action":
                    {
                        movieGenre = MovieGenre.Action;
                        return true;
                    }
                case "romance":
                    {
                        movieGenre = MovieGenre.Action;
                        return true;
                    }
                case "scifi":
                    {
                        movieGenre = MovieGenre.Action;
                        return true;
                    }
                default:
                    {
                        movieGenre = MovieGenre.Horror;
                        return false;
                    }
            }
        }
    }
}
