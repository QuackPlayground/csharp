
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

        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }
        

        // -- END OF FUNCTIONS

        static void Main(string[] args)
        {
            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2 = {0}", solution);
        }
    }
}