using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Override
{
    class Program
    {
        static void Main(string[] args)
        {

            Square newSquare = new Square(12);

            Console.WriteLine(newSquare.Area());
            Console.WriteLine(newSquare.Perimeter());


            Circle newCircle = new Circle(3);

            Console.WriteLine(newCircle.Area());
            Console.WriteLine(newCircle.Perimeter());

            Triangle newTriangle = new Triangle(5, 8);
            Triangle newTriangle2 = new Triangle(5, 8,6);

            Console.WriteLine(newTriangle.Area());
            Console.WriteLine(newTriangle2.Perimeter());

            Console.ReadLine();
        }
    }
}
