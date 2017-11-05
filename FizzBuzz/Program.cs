using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number between one and 100");
            int i = Int32.Parse(Console.ReadLine());
            {


                if ( i % 15 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else if( i % 5 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if ( i % 3 == 0)
                {
                    Console.WriteLine("BUZZ");
                }

                else
                {
                    Console.WriteLine(i);
                }


            };

            Console.ReadLine();
        }
    }
}
