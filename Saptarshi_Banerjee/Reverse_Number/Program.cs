using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int rev = 0;
            while(n>0)
            {
                int rem = n % 10;
                rev = (rev * 10) + rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse No. is {0}", rev);
            Console.ReadLine();
        }
    }
}
