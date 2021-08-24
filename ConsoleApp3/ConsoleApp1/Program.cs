using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 10; a++)
            {
                if (a == 5)
                {
                    Console.WriteLine("a is:" + a);
                    break;

                }



                Console.WriteLine(a);
            }
        }
    }
}
