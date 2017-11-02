﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_QuizOne
{
    class Triangle:Shape
    {
        public Triangle(int TBase, int THeight)
        {
            this.TBase = TBase;
            this.THeight = THeight;
        }
      

        public int TBase { get; set; }
        public int THeight { get; set; }
     

        public override double Area()
        {
            return TBase * THeight / 2;
        }
    }
}
