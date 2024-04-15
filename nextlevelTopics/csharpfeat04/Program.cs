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

        static void Main(string[] args) 
        {
            int num = 1;

            for (int i = 0; i < 10; i++) 
            { 
                Console.WriteLine(num);
                Thread.Sleep(1000); // pause 1s
                num++;
            }

            Console.WriteLine("Thread Ends");
        }
    }
}
