﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class MethodOverriding
    {
        public class Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public virtual void Draw()
            {

            }
        }

        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a circle");
            }
        }
        public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a rectangle");
            }
        }

        // We can create a triangle class and it would have not effect
        // on the shape class circle or any other class 
        // with polymorphism we can simply create new shapes that have no 
        // impact on our exsisting classes, this is also a sign of 
        // loosely coupled classes 
    }
}
