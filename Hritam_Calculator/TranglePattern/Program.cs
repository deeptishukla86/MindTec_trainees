using System;

namespace TranglePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= val; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
