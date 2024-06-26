﻿using chapter2;
using System;

namespace Chapter2
{
    public class Program
    {
        static void Main(String[] args)
        {
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

            foreach (Shape s in shapes) { 
                s.GetInfo();
                Console.WriteLine("{0} Area: {1:f2}", s.Name, s.Area());

                Circle testCirc = s as Circle; // check type
                if (testCirc == null)
                {
                    Console.WriteLine("This isn't a Circle");
                }

                if (s is Circle)
                {
                    Console.WriteLine("This isn't a Rectangle");
                }
            }

            // polymorphism demo
            object circ1 = new Circle(4);

            Circle circ2 = (Circle)circ1;
            Console.WriteLine("The {0} Area is {1:f2}", circ2.Name, circ2.Area());
        }
    }
}