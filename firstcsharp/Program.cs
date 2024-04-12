
using Microsoft.CodeAnalysis;
using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Text; // import namespace system

namespace ConsoleApp1
{
    public class Program
    {

        // -- FUNCTIONS --
        // <Access Specifier> <Return Type> <Method Name> (Parameters)
        // { <Body> } 

        static double GetSum2(double x = 1, double y = 1)
        {
            return x + y;
        }

        static double GetSum2(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }


        // -- END OF FUNCTIONS

        static void Main(string[] args)
        {
            Console.WriteLine("5.0 + 4.5 = {0}", GetSum2(5.0, 4.5));
            Console.WriteLine("5.0 + 4.0 = {0}", GetSum2("5.0", "4.0"));
        }
    }
}