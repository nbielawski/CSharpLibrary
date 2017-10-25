using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string occupation;

            firstName = "Fred";
            lastName = "Rogers";
            occupation = "TV Personality";

            string fullName = firstName +" " + lastName;
            Console.WriteLine(fullName);
           

            Console.WriteLine("Hello, my name is " + fullName + ". I am a " + occupation + ".");

            Console.Write("Hello, My name is {0}. I am a {1}.", fullName, occupation);

            Console.WriteLine($"Hello, my name is {fullName}. I am a {occupation}.");

            //Broze Challenge 
          
            //Silver Challenge

            string potentialEmployerName;
            string date = DateTime.Today.ToShortDateString();
            long phoneNumber = 3175131809;
            string number1 = phoneNumber.ToString("(###)###-####");

            

            potentialEmployerName = "Mr. Jones";

            Console.WriteLine("Dear " + potentialEmployerName + "," +
                "Today is " + date + ". I am enjoying class. I think i enjoy c# the best. I would like to get a" + 
                "job as a developer after i finish the course.");
            Console.WriteLine( "Today is " + date + ". I am enjoying class. I think i enjoy c# the best. I would like to get a job as a developer after i finish the course.");
            

            Console.ReadLine();
        }
    }
}
