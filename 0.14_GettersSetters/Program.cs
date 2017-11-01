﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();

      
            Console.WriteLine("Enter employee name:");
            newEmployee.Name = Console.ReadLine();

            Console.WriteLine("Enter employee ID:");
            newEmployee.ID = int.Parse(Console.ReadLine());

            Console.WriteLine($"New Employee:{newEmployee.Name} {newEmployee.ID}");

            Console.WriteLine($"Enter a common quote for {newEmployee.Name}");
            newEmployee.SetWorkQuote(Console.ReadLine());

            Console.WriteLine(newEmployee.GetQuote());

            Console.ReadLine();

        }
    }
}
