using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Linq;
using System.IO;
using System.Text;


namespace Chapter02
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            string textFilePath3 = @"D:\ngulik\QuackPlayground\csharp\fileio-serialization\dummycsharp01\testfile3.txt";
            StreamWriter sw = new StreamWriter(textFilePath3);
            sw.Write("This is a random ");
            sw.WriteLine("sentence.");
            sw.WriteLine("This is another sentence.");
            sw.Close(); 

            // open file for reading
            StreamReader sr = new StreamReader(textFilePath3);
            Console.WriteLine("Peek: {0}",
                Convert.ToChar(sr.Peek()));

            Console.WriteLine("1st String: {0}",
                sr.ReadLine());

            Console.WriteLine("Everything Else: {0}",
                sr.ReadToEnd());
            sr.Close();
            
        }
    }
}