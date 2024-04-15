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
            Animal bowser = new Animal("Bowser", 45, 25, 1);
            Stream stream = File.Open("AnimalData.dat",
                FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, bowser); // send object data to file
            stream.Close();

            // delete our data
            bowser = null;

            // read object data from file
            stream = File.Open("AnimalData.dat",
                FileMode.Open);
            bf = new BinaryFormatter();

            bowser = (Animal)bf.Deserialize(stream);
            stream.Close();

            Console.WriteLine(bowser.ToString());

        }
    }
}
