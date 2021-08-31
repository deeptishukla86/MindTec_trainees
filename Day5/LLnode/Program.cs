using System;
using System.Collections.Generic;

namespace LLnode
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode<string> lst = new LinkedListNode<string>("Blue");
            Console.WriteLine("After creating the node: ");
            displayProperty(lst);
            LinkedList<string> l = new LinkedList<string>();
            l.AddLast(lst);
            Console.WriteLine("After adding the linked list: ");
            displayProperty(lst);
        }
        public static void displayProperty(LinkedListNode<string> lst)
        {
            if (lst.List == null)
            {
                Console.WriteLine("Node is not linked!");

            }
            else
            {
                Console.WriteLine("Node belongs to the Linked with 0th element!");
            }
        }
    }
}
