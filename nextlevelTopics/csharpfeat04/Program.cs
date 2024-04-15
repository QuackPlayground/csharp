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

        static void CountTo(int maxNum)
        {
            for(int i = 0; i <= maxNum; i++) 
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args) 
        {
            Thread t = new Thread(() => CountTo(10));
            t.Start();

            new Thread(() =>
            {
                CountTo(5);
                CountTo(6);
            }).Start();
        }
    }
}
