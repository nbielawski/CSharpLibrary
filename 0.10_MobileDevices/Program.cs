using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_MobileDevices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze
            MobilePhone jayPhone = new MobilePhone("Motorola", "DynaTAC");
            MobilePhone nickPhone = new MobilePhone("iPhone", "Apple");
            MobilePhone kevinPhone = new MobilePhone("Blackberry", "850");

            Console.WriteLine($"I own a {nickPhone.Make}{nickPhone.Model}.");

            Console.ReadLine();



        }
    }
}
