using System;

namespace reverse_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,rem,rev=0;
        
            Console.WriteLine("enter a number: ");
            number= Convert.ToInt32( Console.ReadLine());
            while (number != 0)
            {
                rem = number % 10;
                rev = rev * 10 + rem;
                number = number / 10;
            }
            Console.WriteLine("reverse number is: "+rev);
        }
    }
}
