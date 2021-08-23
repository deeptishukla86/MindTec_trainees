using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surajit_Rev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int n = int.Parse(System.Console.ReadLine());
            int m = n;
            int k = 0;
            while (n != 0)
            {
                int d = n % 10;
                k = (k * 10) + d;
                n = n / 10;
            }
            Console.WriteLine("The Reverese Of The number " + m + " is " + k);
            Console.ReadLine();
        }
    }
}
