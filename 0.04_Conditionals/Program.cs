using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today on a scale of 1 to 5?");

            string userResponse = Console.ReadLine();
            int userResponseInt = Convert.ToInt32(userResponse);
            if (userResponseInt <= 2)
            {
                Console.WriteLine("Sorry your day sucks!");
            }
            else if (userResponseInt == 3)
            {
                Console.WriteLine("Bleh");
            }
            else
            {
                Console.WriteLine( "Fantastic");
            }


            
        }
    }
}
