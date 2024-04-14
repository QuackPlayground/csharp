using System.Globalization;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace csharpfeat01
{
    public class Program
    {

        delegate double doubleIt(double val);

        static void Main(string[] args)
        {
            // Lambda: allows to use anonymous that defines input on the left and execute on the right

            doubleIt dblIt = x => x * 2;
            Console.WriteLine($"5 * 2 = {dblIt(5)}");

            // u don't have to use delegates
            List<int> numList = new List<int> { 1, 9, 2, 6, 3};

            // Menggunakan .ToList()
            var evenListToList = numList.Where(a => a % 2 == 0).ToList();

            // Tanpa .ToList()
            var evenListNoToList = numList.Where(a => a % 2 == 0);

            Console.WriteLine("Using .ToList():");
            foreach (var num in evenListToList)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Without .ToList():");
            foreach (var num in evenListNoToList)
            {
                Console.WriteLine(num);
            }

            var rangeList = numList.Where(x => (x > 2) || (x < 9)).ToList();
            foreach(var j in rangeList) Console.WriteLine(j);

            List<int> flipList = new List<int>();
            int i = 0;
            Random rnd = new Random();
            while(i < 100)
            {
                flipList.Add(rnd.Next(1, 3)); // generate 1 or 2
                i++;
            }
            Console.WriteLine("Heads: {0}", flipList.Where(a => a == 1).ToList().Count());
            Console.WriteLine("Tails: {0}", flipList.Where(a => a == 2).ToList().Count());

            var nameList = new List<string> { "Doug", "Sally", "Sue" };
            var sNameList = nameList.Where(x => x.StartsWith("S"));
            foreach (var m in sNameList) Console.WriteLine(m);
        }
    }
}
