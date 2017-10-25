using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i <= 10; i++)
            //{

            //    if (i < 10)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else if (i == 10)
            //    {
            //        Console.WriteLine("Launch");
            //    }


            //}

            int n = 0;
            while (n + 5 <= 100)
            {
                Console.WriteLine(n += 5);
            }



            Console.Read();
        }
    }
}
