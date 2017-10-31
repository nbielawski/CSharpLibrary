using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //bronze
            string[] favoriteFoods = new string[3];
            favoriteFoods[0] = "pizza";
            favoriteFoods[1] = "Cheese Burgers";
            favoriteFoods[2] = "Ice Cream";
            foreach (string food in favoriteFoods)
            {
                Console.WriteLine(food);
            }



            //silver

            int[] arrayOdd = new int[5] { 1, 3, 5, 7, 9 };
            int[] arrayEven = new int[5] { 2, 4, 6, 8, 10 };

            Console.WriteLine(arrayOdd[3]+ arrayEven[3]);


            Console.ReadLine();

            //Gold

            int[] randomNumbers = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next(100);
            }

            foreach (int numbers in randomNumbers)
            {
                Console.WriteLine(numbers);
            }
            Console.ReadLine();

        }
    }
}
