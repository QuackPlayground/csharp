using System.Globalization;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace csharpfeat02
{
    public class Program
    {

        delegate double doubleIt(double val);

        static void Main(string[] args)
        {
            var numList2 = new List<int>() {1, 2, 3, 4, 5};

            foreach (var num in numList2) Console.WriteLine(num);

            Console.WriteLine("Sum {0}",
                numList2.Aggregate((a, b) => a + b));

            Console.WriteLine("Average {0}",
                numList2.AsQueryable().Average());

            Console.WriteLine("Is All > 3: {0}",
                numList2.All(x => x > 3)); // false

            Console.WriteLine("Any > 3: {0}",
                numList2.Any(x => x > 3)); // true

            var numList3 = new List<int>() { 1, 2, 3, 3, 2, 3 };
            Console.WriteLine("Distinct: {0}",
                string.Join(", ", numList3.Distinct())); // 1, 2, 3

            var numList4 = new List<int>() { 3 };
            // Mengambil elemen-elemen yang ada di numList3 namun tidak ada di numList4
            Console.WriteLine("Except: {0}",
                string.Join(", ", numList3.Except(numList4))); // 1, 2

            Console.WriteLine("Intersect: {0}",
                string.Join(", ", numList3.Intersect(numList4))); // 3

        }
    }
}
