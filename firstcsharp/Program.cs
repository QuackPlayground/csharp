
using firstcsharp;
using Microsoft.CodeAnalysis;
using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Text; // import namespace system

namespace ConsoleApp1
{
    public class Program
    {

        // -- FUNCTIONS --


        // -- END OF FUNCTIONS


        static void Main(string[] args)
        {
            // create rectangle using struct
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rect1L {0}", rect1.Area());

            Rectangle rect2 = new Rectangle(100, 40);
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine("Rect2.length: {0}", rect2.length);

            Console.WriteLine("----------");
            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaw"
            };
            Console.WriteLine("# of Animals {0}", Animal.GetNumAnimals());
            Console.WriteLine("Area of Rectangle: {0}",
                ShapeMath.GetArea("rectangle", 5, 6));
        }

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w = 1) { length = l; width = w; }
            public double Area()
            {
                return length * width;
            }
        }
    }
}