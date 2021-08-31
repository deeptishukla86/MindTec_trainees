using System;
using System.Collections;

namespace QueueExe
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue s = new Queue();
            s.Enqueue(10);
            s.Enqueue("DXC");
            s.Enqueue(3.14f);
            s.Enqueue(true);
            s.Enqueue('D');

            foreach (object o in s)
            {
                Console.WriteLine(o + "");

            }
            Console.WriteLine();

            Console.WriteLine("total elements "+s.Count);
            Console.WriteLine(s.Dequeue());
            Console.WriteLine();

            foreach (object o in s)
            {
                Console.WriteLine(o + "");

            }
            Console.WriteLine();

            Console.WriteLine(s.Peek());

        }
    }
}
