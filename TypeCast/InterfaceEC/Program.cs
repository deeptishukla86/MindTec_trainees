using System;

namespace InterfaceEC
{
    interface first
    {
        void odd();
        //void even();
    }
    public class test : first
    {
        public void odd()
        {
            Console.WriteLine("This is odd");
            Console.WriteLine("This is one");
            Console.WriteLine("This is three");
            Console.WriteLine("This is five");
        }
        
    }
    public class test1 : first
    {
        public void odd()
        {
            Console.WriteLine("This is even");
            Console.WriteLine("This is two");
            Console.WriteLine("This is four");
        }
    }

        public class inter {
        static void Main(string[] args)
        {
            first t = new test();
            first t1 = new test1();

            t.odd();
            t1.odd();


        }   
       
    }

   }

