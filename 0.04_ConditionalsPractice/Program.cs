using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_ConditionalsPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, Nick!  How many hours of sleep did you get?");
           int hoursOfSleep = int.Parse(Console.ReadLine());

            if (hoursOfSleep > 8)
            {
                Console.WriteLine("You Are Well Rested");
            }
            else
            {
                Console.WriteLine("You need to get more sleep");
            }
            Console.ReadLine();

        }
    }
}
