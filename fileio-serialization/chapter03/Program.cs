using System;
using System.Globalization; // untuk menyediakan kelas dan fungsi-fungsi yang berkaitan dengan pengaturan regional dan budaya dalam pemrosesan teks, tanggal, dan angka. 
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using chapter03;

namespace Chapter03
{
    public class Program
    {
        static void Main(string[] args)
        {

            // collection of animal
            List<Animal> theAnimals = new List<Animal>
            {
                new Animal("Mario", 60, 30, 2),
                new Animal("Luigi", 55, 24, 3),
                new Animal("Peach", 40, 20, 4)
            };

            using (Stream fs = new FileStream(@"D:\ngulik\QuackPlayground\csharp\fileio-serialization\dummycsharp01\animals.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
                serializer2.Serialize(fs, theAnimals);
            }

            theAnimals = null;

            XmlSerializer serializer3 = new XmlSerializer(typeof(List<Animal>));

            using (FileStream fs2 = File.OpenRead(@"D:\ngulik\QuackPlayground\csharp\fileio-serialization\dummycsharp01\animals.xml"))
            {
                theAnimals = (List<Animal>)serializer3.Deserialize(fs2);
            }

            foreach(Animal a in theAnimals)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}
