﻿using System;

namespace csharpfeat03
{
    public class Program
    {
        static void Main(string[] args)
        {
            AnimalFarm myAnimals = new AnimalFarm();
            myAnimals[0] = new Animal("Wilbur");
            myAnimals[1] = new Animal("Templeton");
            myAnimals[2] = new Animal("Gander");
            myAnimals[3] = new Animal("Charlotte");

            foreach(Animal i in myAnimals) Console.WriteLine(i.Name);

            // That is how to create very customize collection types

            //----------------------------
            Console.WriteLine("\n");

            Box box1 = new Box(2, 3, 4);
            Box box2 = new Box(5, 6, 7);
            Box box3 = box1 + box2;

            Console.WriteLine($"Box 3: {box3}");
            Console.WriteLine($"Box Int: {(int)box3}");

            Box box4 = (Box)4;
            Console.WriteLine($"Box 4: {box4}");
        }
    }
}