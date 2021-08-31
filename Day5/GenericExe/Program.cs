using System;
using System.Collections.Generic;

namespace GenericExe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> o = new List<int>();
            Console.WriteLine("intial capacity " + o.Capacity);
            o.Add(10);
            o.Add(20);
            Console.WriteLine("after 2 elements " + o.Capacity);
            o.Add(30);
            o.Add(40);
            Console.WriteLine("after 4 elements " + o.Capacity);
            o.Add(50);
            Console.WriteLine("after 5 elements " + o.Capacity);

            for (int i = 0; i < o.Count; i++)
            {
                  
               Console.WriteLine("list is " + o[i]) ;
            }
            Console.WriteLine();
            o.Remove(30);
            Console.WriteLine("size of list " + o.Count);
            Console.WriteLine();

            for (int i = 0; i < o.Count; i++)
            {
                Console.WriteLine("list is " + o[i]);
            }

        }

    }
}
