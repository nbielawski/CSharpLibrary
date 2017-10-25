using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What you got in the bank?");

            string bankAccount = Console.ReadLine();
            int bankAccountInt = Convert.ToInt32(bankAccount);



            if (bankAccountInt < 1000)
            {
                Console.WriteLine("You're Broke!");
            }

            else
            {
                Console.WriteLine("You're rich!");
            }
            Console.ReadLine();
        }
    }
}
