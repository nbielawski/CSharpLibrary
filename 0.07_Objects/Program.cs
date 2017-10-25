using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Objects
{
    class Program
    {
        static void Main(string[] args)
        {

            Donut jellyDonut = new Donut();
            Donut kennDonut = new Donut();
            Donut nickDonut = new Donut();

            jellyDonut.Filling = "Cherry Jely";
            jellyDonut.Price = 7.99M;
            jellyDonut.Type = "Jelly";
            jellyDonut.IsSpecial = true;

            kennDonut.Filling = "strawberry Jely";
            kennDonut.Price = 0;
            kennDonut.Type = "Jelly";
            kennDonut.IsSpecial = false;

            nickDonut.Filling = "chocolate";
            nickDonut.Price = 1.99M;
            nickDonut.Type = "Awesome";
            nickDonut.IsSpecial = true;

            Console.WriteLine(jellyDonut);
            Console.Read();
        }
    }
}
