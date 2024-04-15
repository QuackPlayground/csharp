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
            BankAcct acct = new BankAcct(10);
            Thread[] threads = new Thread[15];

            Thread.CurrentThread.Name = "main"; // Memberi nama thread utama (main) sebagai "main".

            // Loop untuk membuat 15 thread baru.
            for (int i = 0; i < 15; i++)
            {
                Thread t = new Thread(new ThreadStart(acct.IssueWithdraw));
                t.Name = i.ToString(); // Memberi nama thread sesuai dengan indeksnya dalam loop.
                threads[i] = t;
            }

            // Loop untuk memulai dan menampilkan status 15 thread yang telah dibuat.
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Thread {0} Alive: {1}", threads[i].Name, threads[i].IsAlive); // Menampilkan status (hidup/mati) dari thread dengan nama dan status IsAlive yang sesuai.
                threads[i].Start(); // Memulai eksekusi thread.

                Console.WriteLine("Thread {0} Alive: {1}", threads[i].Name, threads[i].IsAlive); // Menampilkan status setelah thread dimulai.
            }

            Console.WriteLine("Current Priority: {0}", Thread.CurrentThread.Priority); // Menampilkan prioritas thread utama.
            Console.WriteLine("Thread {0} Ending", Thread.CurrentThread.Name); // Menampilkan bahwa thread utama telah selesai.
        }
    }
}
