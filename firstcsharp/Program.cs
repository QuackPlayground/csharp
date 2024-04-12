
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

        // now you have access to the value from outside your function
        public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }
        

        // -- END OF FUNCTIONS

        static void Main(string[] args)
        {
            int num3 = 10;
            int num4 = 20;

            Console.WriteLine("Before Swap num1: {0}, num2: {1}",
                num3, num4);

            Swap(ref num3, ref num4);

            Console.WriteLine("After Swap num1: {0}, num2: {1}",
                num3, num4);

        }
    }
}