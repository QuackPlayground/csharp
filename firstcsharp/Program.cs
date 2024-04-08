using System; // import namespace system

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Biggest Double: {0}", Double.MaxValue);
            Console.WriteLine("Smallest Double: {0}", Double.MinValue);
            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000002;
            Console.WriteLine("DBL: PI + BigNum = {0}",
                dblPiVal + dblBigNum);

            Console.WriteLine("Biggest Float: {0}", float.MaxValue);
            Console.WriteLine("Smallest Float: {0}", float.MinValue);
            double fltPiVal = 3.141592F;
            double fltBigNum = 3.000002F;
            Console.WriteLine("FLT: PI + BigNum = {0}",
                fltPiVal + fltBigNum);
        }
    }
}