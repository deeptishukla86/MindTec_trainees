using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int sum = 0;
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                sum = sum + i;
            }
                Console.WriteLine("sum of natural number  is:" + sum);
            
        }
        
    }
   
}

