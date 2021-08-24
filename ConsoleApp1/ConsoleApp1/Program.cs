using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int a, b;
        public static void  add(int a,int b)
        {
            Console.WriteLine("add:" + (a + b));
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine("sub:" + (a - b));
        }
        public static void multi(int a,int b)
        {
            Console.WriteLine("mul:" + a * b);
        }
        public static void div(int a, int b)
        {
            Console.WriteLine("div:" + (a / b));
        }
        static void Main(string[] args)
        {
            a = 5;
            b = 10;
            add(a,b);
            sub(a, b);
            multi(a, b);
            div(a, b);
           
           
        }
    }
}
