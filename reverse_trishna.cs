using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, rev = 0, rem;
            Console.WriteLine("enter the number:");
            n = Convert.ToInt32(Console.ReadLine());
            while(n!=0)
            {
                rem = n % 10;
                rev = rem + rev * 10;
                n = n / 10;
            }
            Console.WriteLine("Reverse of the " + n + "is:" + rev);
            Console.ReadLine();
        }
    }
}
