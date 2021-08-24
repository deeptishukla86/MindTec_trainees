using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Console.Write("Enter your choice: ");
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 10:
                    Console.WriteLine("You have choosen number 10");
                    break;
                case 20:
                    Console.WriteLine("You have choosen number 20");
                    break;
                case 30:
                    Console.WriteLine("You have choosen number 30");
                    break;
                default:
                    Console.WriteLine("Please choose correct number!!!");
                    break;
            }
        }
    }

}
