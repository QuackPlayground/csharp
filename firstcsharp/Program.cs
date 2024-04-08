using System; // import namespace system

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] favNums = new int[3];
            favNums[0] = 23;
            Console.WriteLine("favNum at index 0: {0}", favNums[0]);

            string[] customers = { "Bob", "Sally", "Sue" };
            var employees = new[] { "Mike", "Paul", "Rick" };

            // array for different types with object
            object[] randomArray = { "Paul", 45, 1.234 };

            Console.WriteLine("randomArray 0: {0}", randomArray[0].GetType());
            Console.WriteLine("Array Size: {0}", randomArray.Length);
        }
    }
}