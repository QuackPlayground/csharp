using System;
using System.Collections;


namespace LearnStacks
{
    public class Program
    {
        static void Main(string[] args) 
        {
            // Last In First Out
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Peek 1: {0}", stack.Peek());
            Console.WriteLine("Pop 1: {0}", stack.Pop());

            Console.WriteLine("Contain 1: {0}", stack.Contains(1));

            // copy stack into array
            object[] numArray2 = stack.ToArray();

            Console.WriteLine(String.Join(",", numArray2));

            foreach (object o in stack)
            {
                Console.WriteLine($"Stack: {o}");
            }
        }
    }
}