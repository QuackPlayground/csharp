using System; // import namespace system

namespace ConsoleApp1
{
    public class Program
    {

        // -- FUNCTIONS --

        static void PrintArray(int[] intArray, string mess)
        {
            foreach(int k in intArray)
            {
                Console.WriteLine("{0}: {1}", mess, k);
            }
        }

        // -- END OF FUNCTIONS

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

            for (int j = 0; j < randomArray.Length; j++)
            {
                Console.WriteLine("Array: {0}, Value: {1}", j, randomArray[j]);
            }

            Console.WriteLine("------------------");

            // multidimensional array
            string[,] custNames = new string[2, 2] { { "Bob", "Smaith" }, { "Sally", "Smith" } };

            Console.WriteLine("MD Value: {0}", custNames.GetValue(0, 1));

            for (int j = 0; j < custNames.GetLength(0); j++)
            {
                for (int k = 0; k < custNames.GetLength(0); k++)
                {
                    Console.WriteLine("{0} ", custNames[j, k]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------");

            int[] randNums = { 1, 4, 9, 2 };
            PrintArray(randNums, "ForEach");

            Console.WriteLine("--------");

            Array.Sort(randNums); // [1, 2, 4, 9]
            Array.Reverse(randNums); // [9, 4, 2, 1]

            Console.WriteLine("1 at index: {0}", Array.IndexOf(randNums, 1));

            randNums.SetValue(0, 1);

            // copy array
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;

            
            Array.Copy(srcArray, startInd, destArray, 0, length);
            PrintArray(destArray, "Copy");

            Console.WriteLine();

            // another way to create array
            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);
            foreach(int m in anotherArray)
            {
                Console.WriteLine("CopyTo: {0} ", m);
            }

        }
    }
}