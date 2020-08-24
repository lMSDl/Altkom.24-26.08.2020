﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    abstract class Shape
    {
        public abstract int Area { get; }
    }

    class Square : Shape
    {
        public int A { get; set; }

        public override int Area => A * A;
    }

    class Rectangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }

        public override int Area => A * B;
    }

    class Circle : Shape
    {
        public int R { get; set; }

        public override int Area => (int)(R * R * Math.PI);
    }

    class ShapeCalculator
    {
        int Area(Shape shape)
        {
            return shape.Area;
        }
    }
}
