using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Override
{
    class Circle:Shape
    {
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int radius { get; set; }

        public override double Area()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public override double Perimeter()
        {
            return radius * 2 * Math.PI; 
        }
        
        
        
    }
}
