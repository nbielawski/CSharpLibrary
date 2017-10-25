using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Paul";

            switch (friend)
            {
                case "Jay":
                    Console.WriteLine("Hey, Jay!");
                    break;

                case "Paul":
                    Console.WriteLine("Paul is cool!");
                    break;
                case "ken)":
                    Console.WriteLine("Silent master Ken");
                    break;
                default:
                    Console.WriteLine("Sorry i do not know you!");
                    break;
            }
            Console.Read();
        }
    }
}
