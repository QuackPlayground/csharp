using System; // import namespace system

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string randString = "This is a string";
            Console.WriteLine("String Length: {0}", randString.Length);
            Console.WriteLine("String Contains is: {0}", randString.Contains("is"));
            Console.WriteLine("Index of is: {0}", randString.IndexOf("is"));
            Console.WriteLine("Remove String: {0}", randString.Remove(10, 6));
            Console.WriteLine("Insert String: {0}", randString.Insert(10, "short")); // insert in index 10 -> word "short"
            Console.WriteLine("Replace String: {0}", randString.Replace("string", "sentence")); // replace "string" with "sentence"
            Console.WriteLine("Compare A to B: {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase)); // dengan mengabaikan perbedaan huruf besar-kecil (case-insensitive).

            Console.WriteLine("----------------------");

            Console.WriteLine("A = a: {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Pad Left: {0}", randString.PadLeft(20, '.'));
            Console.WriteLine("Pad Right: {0}", randString.PadRight(20, '.'));
            Console.WriteLine("Trim : {0}", randString.Trim());
            Console.WriteLine("Uppercase: {0}", randString.ToUpper());
            Console.WriteLine("Lowercase: {0}", randString.ToLower());
        }
    }
}