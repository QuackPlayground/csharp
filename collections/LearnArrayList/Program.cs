using System;
using System.Collections; // for array list
using System.Collections.Generic; // for dictionary

namespace LearnArrayList 
{ 
    
    public class Program
    {
        static void Main(string[] args)
        {
            #region Array List Code

            ArrayList aList = new ArrayList();

            aList.Add("Bob");
            aList.Add(40);

            Console.WriteLine("Count: {0}", aList.Count); // total number of values installed of it
            Console.WriteLine("Capacity: {0}", aList.Capacity);

            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });

            aList.AddRange(aList2 );

            aList2.Sort(); // if the type is same
            aList2.Reverse();

            aList.Insert(1, "Turkey"); // insert value


            Console.WriteLine("aList");
            foreach (var value in aList)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("\n");

            Console.WriteLine("aList2");
            foreach (var value in aList2)
            {
                Console.WriteLine(value);
            }

            aList2.RemoveAt(0); // remove first one
            aList2.RemoveRange(0, 2);

            Console.WriteLine("\n");

            Console.WriteLine("aList2");
            foreach (object value in aList2)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Turkey Index: {0}",
                aList2.IndexOf("Turkey", 0)); // pencarian akan dimulai dari index 0. Jika tidak ada akan return -1


            // we can convert arraylist into string array
            string[] myArray = (string[]) aList2.ToArray(typeof(string));

            string[] customer = { "Bob", "Sally", "Sue" };
            ArrayList custArrayList = new ArrayList();
            custArrayList.AddRange(customer); 



            #endregion
        }
    }

}
