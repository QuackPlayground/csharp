using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstcsharp
{
    class Animal
    {
        private string name;
        protected string sound;

        protected AnimalIDInfo animalIdInfo = new AnimalIDInfo();

        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIdInfo.IDNumber = idNum;
            animalIdInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIdInfo.IDNumber} and is owned by {animalIdInfo.Owner}");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        // constructor chaining
        public Animal() : this("No Name", "No Sound") { } // default animal if nothing set

        public Animal(string name) : this (name, "No Sound") { }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    name = "No Name";
                    Console.WriteLine("Can't use numbers in name");
                }
                name = value;
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                } else
                {
                    sound = value;
                }
            }
        }

        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;
                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else return false;
            }
        }

        

    }
}
