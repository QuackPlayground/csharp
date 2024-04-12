using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstcsharp
{
    class Animal
    {
        public string name;
        public string sound;
        static int numOfAnimals = 0;

        // constructor
        public Animal()
        {
            name = "No Name";
            sound = "No Sound";
            numOfAnimals++;
        }

        // constructor overloading
        public Animal(string name = "No Name")
        {
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name", string sound = "No Sound")
        {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        // method
        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", this.name, this.sound);
        }

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }

    }
}
