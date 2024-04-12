using System;
using System.Globalization;
using System.Text; // import namespace system

namespace ConsoleApp1
{
    public class Program
    {

        // -- FUNCTIONS --

        

        // -- END OF FUNCTIONS

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Random Text");
            StringBuilder sb2 = new StringBuilder("More Stuff that is very important", 256);

            Console.WriteLine("Capactiy: {0}", sb2.Capacity);
            Console.WriteLine("Length: {0}", sb2.Length);

            sb2.AppendLine("\nMore important text");
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");

            string bestCust = "Bob Smith";
            // untuk menambahkan string dengan format tertentu ke sb2, di mana {0} akan digantikan dengan nilai dari bestCust.
            sb2.AppendFormat(enUS, "Best Customer: {0}", bestCust);

            Console.WriteLine(sb2.ToString());
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());
            sb2.Clear();
            sb2.Append("Random Text");
            Console.WriteLine(sb.Equals(sb2));

            sb2.Insert(11, " that's great");
            Console.WriteLine(sb2.ToString());

            // remove 
            sb2.Remove(11, 7);
            Console.WriteLine(sb2.ToString());
        }
    }
}