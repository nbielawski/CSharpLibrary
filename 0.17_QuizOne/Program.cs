using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_QuizOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle Triangle1 = new Triangle(1, 2);
            Triangle Triangle2 = new Triangle(3, 4);
            Triangle Triangle3 = new Triangle(5, 6);
            Triangle Triangle4 = new Triangle(7, 8);
            Triangle Triangle5 = new Triangle(9, 10);

            Console.WriteLine(Triangle1.Area());
            Console.WriteLine(Triangle2.Area());
            Console.WriteLine(Triangle3.Area());
            Console.WriteLine(Triangle4.Area());
            Console.WriteLine(Triangle5.Area());


            IEnumerable<Triangle> triangles = new List<Triangle>()
            {
                Triangle1,
                Triangle2,
                Triangle3,
                Triangle4,
                Triangle5

            };

            IEnumerable<Triangle> query = from t in triangles
                                           where  t.TArea >3
                                           orderby t.TArea ascending
                                           select t;
            foreach (Triangle triangle in triangles)
            {
                Console.WriteLine(triangle.TArea);
            }

            Console.ReadLine();
        }
    }
}
