using System;

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
        }
    }
}