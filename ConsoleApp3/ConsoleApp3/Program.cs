using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            String str, rev;
            str = "Hello";
            rev = " ";
                int a = str.Length - 1;
            while(a>=0)
            {
                rev = rev + str[a];
                a--;
            }
            Console.WriteLine(rev);
        }
    }
}
