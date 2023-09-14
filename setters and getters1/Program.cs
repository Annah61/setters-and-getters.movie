using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setters_and_getters1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            movie movie1 = new movie("Titanic", "Jim", "PG-13");
            movie movie2 = new movie("The unreleased movie", "Evans", "Cat");
            movie movie3 = new movie("The unrealeased movie", "Evans", "Cat");

            Console.WriteLine(movie2.rating);
            Console.WriteLine(movie.moviecount);
            //freeze
            Console.ReadLine();
        }
    }
}
