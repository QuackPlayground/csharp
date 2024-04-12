
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

        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}",  name, zipCode);
        }
        

        // -- END OF FUNCTIONS

        static void Main(string[] args)
        {
            PrintInfo(zipCode: 15417, name: "Pocky Poem");
        }
    }
}