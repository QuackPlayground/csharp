using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Linq;


namespace csharpfeat04
{
    public class Program
    {

        static void Print1()
        {
            for (int i = 0; i < 1000; i++) 
            {
                Console.Write(1);
            }
        }

        static void Main(string[] args) 
        {
            Thread t = new Thread(Print1);
            t.Start(); // try to print thousand of 1

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(0);
            }
        }
    }
}
