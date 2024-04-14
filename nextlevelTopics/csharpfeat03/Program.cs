using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections;

namespace csharpfeat03
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList animalList = new ArrayList()
            {
                new Animal {Name="German Shephard", Height= 25, Weight=77},
                new Animal {Name="Chihuahua", Height=7, Weight=4.4},
                new Animal {Name="Saint Bernard", Height=30, Weight=200}
            };

            var animalListEnum = animalList.OfType<Animal>();

            var bigDogs = from dog in animalListEnum
                          where (dog.Weight > 70) &&
                          (dog.Height > 25)
                          orderby dog.Name
                          select dog;

            
            
            foreach(var animal in bigDogs ) Console.WriteLine("{0} weights {1}lbs", animal.Name, animal.Weight);
        }
    }
}