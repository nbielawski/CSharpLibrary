using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Netflix Movie1 = new Netflix();
            Netflix Movie2 = new Netflix();
            Netflix Movie3 = new Netflix();

            Movie1.MovieName = "Braveheart";
            Movie1.Genre = "Action";
            Movie1.MovieRating = 5.0;

            Movie2.MovieName = "Oldschool";
            Movie2.Genre = "Comedy";
            Movie2.MovieRating = 3.2;

            Movie3.MovieName = "Legally Blonde";
            Movie3.Genre = "Comedy";
            Movie3.MovieRating = 1.1;

            Console.WriteLine("What movie would you like to watch? Please enter from the list: Braveheart, Oldschool, Legally Blonde");
            Console.ReadLine();

            
        }
    }
}
