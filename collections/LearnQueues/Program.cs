using System;
using System.Collections;
using System.Collections.Generic;

namespace LearnQueues
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("1 in Queue: {0}", queue.Contains(1));

            Console.WriteLine("Remove 1: {0}", queue.Dequeue());

            Console.WriteLine("Peek: {0}", queue.Peek()); // melihat elemen pertama tanpa menghapus

            //  untuk mengonversi semua elemen dalam Queue menjadi array object[]
            object[] numArray = queue.ToArray();

            Console.WriteLine(String.Join(",", numArray));

            Console.WriteLine("Queue's Items: ");
            foreach (object o in queue)
            {
                Console.WriteLine($"Queue: {o}");
            }
            Console.WriteLine();

            queue.Clear();

        }
    }
}