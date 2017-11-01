using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_MethodsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a player class with 3 Attack() methods that accepts 3 diffent sets of parameters
            //Ex:  Attack(100) --> Attacked for 100!
            //Attack(100, "weapon") --> Attacked with weapon for 100
            //Attack(100, "weapon", #ofTimes) -->  Attacked with weapon for 100 #ofTimes, dealing totalDamage
            Player Nick = new Player();
            Nick.Attack(100);

            Nick.Attack(100, "sword");

            Nick.Attack(100, "sword", 6);

            Nick.Attack();

            Console.ReadLine();
        }
    }
}
