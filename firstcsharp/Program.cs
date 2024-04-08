using System; // import namespace system

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");

            string strVal = dblFromStr.ToString();
            Console.WriteLine($"Data type: {strVal.GetType()}");

            // explicit conversion
            double dblNum = 12.345;
            Console.WriteLine($"Integer: ${(int)dblNum}");

            // implicit conversion (smaller size to bigger size data types)
            int intNum = 10;
            long longNum = intNum;


        }
    }
}