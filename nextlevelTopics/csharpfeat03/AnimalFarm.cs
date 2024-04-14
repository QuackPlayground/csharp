using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpfeat03
{
    class AnimalFarm : IEnumerable 
    {
        private List<Animal> animalList = new List<Animal>();

        public AnimalFarm(List<Animal> animalList)
        {
            this.animalList = animalList;
        }

        public AnimalFarm() { }

        // we will create an indexer so we could sort throught our list
        // Indexer digunakan untuk memberikan akses indeks ke objek, mirip dengan penggunaan indeks pada array
        public Animal this[int index]
        {
            get { return (Animal)animalList[index]; }
            set { animalList.Insert(index, value); }
        }

        // get number the animals that store
        public int Count
        {
            get { return animalList.Count; }
        }

        public IEnumerator GetEnumerator()
        {
            // return enumerator that will be used to iterate through our Animal Collection
            return animalList.GetEnumerator();
        }

        
    }
}
