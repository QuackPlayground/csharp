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
            Animal[] animals= new []
            {
                new Animal {Name="German Shephard", Height= 25, Weight=77, AnimalID = 1},
                new Animal {Name="Chihuahua", Height=7, Weight=4.4, AnimalID = 2},
                new Animal {Name="Saint Bernard", Height=30, Weight=200, AnimalID = 3},
                new Animal {Name="Pug", Height=12, Weight=6, AnimalID = 1},
                new Animal {Name="Beagle", Height=15, Weight=23, AnimalID = 2}
            };

            Owner[] owners = new[]
            {
                new Owner {Name = "Doug Parks", OwnerID = 1},
                new Owner {Name = "Sally Smith", OwnerID = 2},
                new Owner {Name = "Paul Brooks", OwnerID=3}
            };


            var nameHeight = from a in animals
                             select new
                             {
                                 a.Name,
                                 a.Height
                             };

            
            Array arrNameHeight = nameHeight.ToArray();

            var innerjoin =
                from animal in animals
                join owner in owners on animal.AnimalID
                equals owner.OwnerID
                select new { OwnerName = owner.Name, AnimalName = animal.Name };

            var groupJoin =
                from owner in owners
                orderby owner.OwnerID
                join animal in animals on owner.OwnerID
                equals animal.AnimalID into ownerGroup
                select new
                {
                    Owner = owner.Name,
                    Animals = from animal in ownerGroup
                              orderby animal.Name
                              select animal
                };

           
           
           
            foreach(var i in arrNameHeight ) Console.WriteLine(i.ToString());

            Console.WriteLine("\n");
            Console.WriteLine("Inner Join Result: ");

            foreach (var i in innerjoin) Console.WriteLine("{0} owns {1}", i.OwnerName, i.AnimalName);

            // cycle through different owner groups
            Console.WriteLine("\n");
            Console.WriteLine("Group Inner Join Result: ");

            int totalAnimals = 0;

            foreach (var ownerGroup in groupJoin)
            {
                Console.WriteLine(ownerGroup.Owner);
                foreach(var animal in ownerGroup.Animals)
                {
                    totalAnimals++;
                    Console.WriteLine("* {0}", animal.Name);
                }
            }
        }
    }
}