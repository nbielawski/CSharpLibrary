using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Override
{
    class Triangle:Shape
    {

        public Triangle (int bottom, int height)
        {
            this.bottom = bottom;
            this.height = height;
        }
        public Triangle (int side1, int side2, int side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public int bottom { get; set; }
        public int height { get; set; }
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }

        public override double Area()
        {
            return bottom * height / 2;
        }

        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }
        
    }
}
