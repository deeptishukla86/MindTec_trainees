using System;
using System.Collections.Generic; 
namespace Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> obj = new LinkedList<string>();
            obj.AddLast("abhi");
            obj.AddFirst("aarohi");
            var newNode = obj.AddLast("akshay");
            //obj.AddAfter(newNode, "akash");
            obj.AddAfter(newNode, "bindu");
            obj.AddFirst("rohi");
           // obj.AddLast("raj");
            
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            obj.RemoveLast();
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }

        }
    }
}
