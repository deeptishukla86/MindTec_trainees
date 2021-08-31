using System;
using System.Collections;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(10);
            s.Push("DXC");
            s.Push(3.14f);
            s.Push(true);
            s.Push('D');

            foreach (object o in s)
            {
                Console.WriteLine(o + "");

            }
            Console.WriteLine(s.Count);

            Console.WriteLine(s.Pop());
            Console.WriteLine("  ");

            foreach (object o in s)
            {
                Console.WriteLine(o + "");

            }
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Count);

        }
    }
}


