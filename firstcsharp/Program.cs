using System; // import namespace system

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Currency: {0:c}", 23.455); // $23.45
            Console.WriteLine("Pad with 0s: {0:d4}", 23); // d4 = 4 spaces -> 0023
            Console.WriteLine("3 Decimals: {0:f3}", 23.45555); // 23.456
            Console.WriteLine("Commas: {0:n4}", 2300); // 2,300.0000
        }
    }
}