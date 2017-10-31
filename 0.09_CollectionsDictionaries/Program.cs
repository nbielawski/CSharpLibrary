using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_CollectionsDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
           //Bronze Challenge
            //Create a dictionary that has all the academy Award winners for best picture from 2000-2005. (Use wikipedia for winners). 

            Dictionary<string, string> AwardWinners = new Dictionary<string, string>();
            AwardWinners.Add("2000", "American Beauty");
            AwardWinners.Add("2001", "Gladiator");
            AwardWinners.Add("2002", "Beautiful Mind");
            AwardWinners.Add("2003", "Chicago");
            AwardWinners.Add("2004", "LOTR");
            AwardWinners.Add("2005", "Million $ Baby");

            foreach (var movie in AwardWinners)
            {

                Console.WriteLine($"{movie.Key} the winner was {movie.Value}");
            }
            
            Console.ReadLine();

            //Silver Challenge


            Dictionary<string, string[]> AwardNominees = new Dictionary<string, string[]>()
            {
                {"2006", new string[]{"Happy Feet", "Cars", "Monster House" } },
                {"2007", new string[]{"Ratatoullie", "persepolis", "Surfs up" } },
                {"2008", new string[]{"Wall-E", "Bolt", "KungFuPanda" } },
                {"2009", new string[]{"Up", "Mr. Fantastic", "Coralinne" } },
                {"2010", new string[]{"Toy Story", "How to Train your Dragon", "The Illusionist" } }
            };

            foreach (var nominee in AwardNominees)
            {
                Console.WriteLine($"Nominees for {nominee.Key}: {nominee.Value [0]},{nominee.Value [1]},{nominee.Value [2]}" );
            }

            Console.ReadLine();





        }
    }
}
