using System;
using System.Linq;
using System.Xml.Linq;

namespace csharpfeat03
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Language Integrated Query (LINQ)
            string[] dogs = { "K 9", "Brian Griffin", "Scooby Doo", "Old Yeller", "Rin Tin Tin", "Benji", "Charlie B. Barkin", "Lassie", "Snoopy" };

            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            foreach (var i in dogSpaces) Console.WriteLine(i);
        }
    }
}