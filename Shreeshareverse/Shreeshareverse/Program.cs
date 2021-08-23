using System;

namespace Shreeshareverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int reverse = 0, rem;
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            while(n!=0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("eversed Number:" + reverse);
        }
    }
}
