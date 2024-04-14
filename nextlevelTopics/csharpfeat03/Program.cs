using System;
using System.Linq;
using System.Xml.Linq;

namespace csharpfeat03
{
    public class Program
    {

        static int[] QueryIntArray()
        {
            int[] nums = {5, 10, 15, 20, 25, 30, 35};

            var gt20 = from num in nums
                       where num > 20
                       orderby num
                       select num;

            foreach(int num in gt20) Console.WriteLine(num);

            Console.WriteLine($"Get Type: {gt20.GetType()}");

            Console.WriteLine();

            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();

            nums[0] = 40;
            foreach (int num in gt20) Console.WriteLine(num);

            Console.WriteLine() ;

            return arrayGT20;
        }

        static void Main(string[] args)
        {
            int[] intArray = QueryIntArray();

            foreach (int num in intArray) Console.WriteLine(num);
        }
    }
}