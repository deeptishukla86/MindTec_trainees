using System;

namespace TypeCast
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            object obj = num;
            int i = (int)obj;
            Console.WriteLine("value is " + obj);
            Console.WriteLine("i" + i);

        }
    }
}
