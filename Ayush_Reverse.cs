using System;

namespace AyushGupta
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rev = 0, rem;
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Reversed Number: " + rev);
            Console.ReadKey();
        }
    }
}
