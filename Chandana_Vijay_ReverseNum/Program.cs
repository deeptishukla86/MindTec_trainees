using System;

namespace Chandana_Vijay_ReverseNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int rev = 0, n, rem;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Reversed Number: " + rev);
        }
    }
}
