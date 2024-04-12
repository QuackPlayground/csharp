
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
            Animal cat = new Animal();
            cat.SetName("Whiskers");
            cat.Sound = "Meow";
            Console.WriteLine("The cat is name {0} and says {1}",
                cat.GetName(), cat.Sound);
            cat.Owner = "Naufal";
            Console.WriteLine("{0} owner is {1}",
                cat.GetName(), cat.Owner);

            Console.WriteLine("{0} shelter id is {1}",
                cat.GetName(), cat.idNum);

            Console.WriteLine("# of animals: {0}",
                Animal.NumOfAnimals);

        }

    }
}