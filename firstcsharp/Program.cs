
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
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrr"
            };

            grover.Sound = "Wooooof";

            whiskers.MakeSound();
            grover.MakeSound();

            whiskers.SetAnimalIDInfo(12345, "Sally Smith");
            grover.SetAnimalIDInfo(12346, "Paul Brown");

            whiskers.GetAnimalIDInfo();

            // inner class test
            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is my animal healthy: {0}",
                getHealth.HealthyWeight(11, 46));

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wooooffff",
                Sound2 = "Geeeerrrr"
            };

            spot.MakeSound();
            
            
        }

    }
}