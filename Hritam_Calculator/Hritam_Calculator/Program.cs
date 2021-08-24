using System;

namespace Hritam_Calculator
{
    class Program
    {
        static int num1;
        static int num2;
        static void Main(string[] args)
        {
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            add(num1, num2);
            subtract(num1, num2);
            multiply(num1, num2);
            divide(num1, num2);
        }

        private static void divide(int num1, int num2)
        {
            Console.WriteLine("Divition: " + (num1 / num2));
        }

        private static void multiply(int num1, int num2)
        {
            Console.WriteLine("Multiplication: " + (num1 * num2));

        }

        private static void subtract(int num1, int num2)
        {
            Console.WriteLine("Subtraction: " + (num1 - num2));
        }

        private static void add(int num1, int num2)
        {
            Console.WriteLine("Addition: " + (num1 + num2));
        }
    }
}
