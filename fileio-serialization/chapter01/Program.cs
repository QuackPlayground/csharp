using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Linq;
using System.IO;

namespace Chapter01
{
    public class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currDir = new DirectoryInfo("."); // current directory
            DirectoryInfo pockyDir = new DirectoryInfo(@"D:\ngulik\QuackPlayground");

            Console.WriteLine(currDir.FullName);

            Console.WriteLine(pockyDir.FullName); // D:\ngulik\QuackPlayground
            Console.WriteLine(pockyDir.Name); // QuackPlayground
            Console.WriteLine(pockyDir.Parent); // D:\ngulik
            Console.WriteLine(pockyDir.Attributes); // Directory
            Console.WriteLine(pockyDir.CreationTime); // 08/01/2024 12:33:23

            DirectoryInfo dataDir = new DirectoryInfo(@"D:\ngulik\QuackPlayground\csharp\fileio-serialization\dummycsharp01");
            dataDir.Create();
        }
    }
}
