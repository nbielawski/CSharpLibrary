using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_MethodsOverloading
{
    class Player
    {
        public void Attack()
        {
            Console.WriteLine("You Attacked");
        } 
            
            public void Attack(int attackLevel)
        {
            Console.WriteLine("Attack for {0}", attackLevel);
      
        }

        public void Attack (int attackLevel, string weapon)
        {
            Console.WriteLine("Attack for {0} with {1}", attackLevel , weapon);
        } 

        public void Attack (int attackLevel, string weapon, int numOfTimes)
        {
           int totalDamage = attackLevel * numOfTimes;

            Console.WriteLine($"Attack for {attackLevel} with {weapon} {numOfTimes} times for {totalDamage}", attackLevel, weapon, numOfTimes);
        }
    }
}
