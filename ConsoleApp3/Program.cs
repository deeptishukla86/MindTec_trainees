using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,i;
            Console.WriteLine("Enter any integer below 10");
            x = Convert.ToInt32(Console.ReadLine());
            if (x<=10)
            {
                Console.WriteLine("Using For Loop...");
                for(i=1; i<=10; i++)
                {
                    Console.WriteLine(x + " x " + i + "=" + x * i);
                }

                Console.WriteLine("Using While Loop...");
                i = 1;
                while (i <= 10)
                {
                    Console.WriteLine(x + " x " + i + "=" + x * i);
                    i++;
                }

                Console.WriteLine("Using Do While Loop...");
                i = 1;
                do
                {
                    Console.WriteLine(x + " x " + i + "=" + x * i);
                    i++;
                } while (i <= 10);
            }
            else
            {
                Console.WriteLine("Wrong Input! Close and Try again!");
            }

        }
    }
}
