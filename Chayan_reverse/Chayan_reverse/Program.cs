using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chayan_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int rev = 0, rem;
            while (n != 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n/ 10;
            }
            System.Console.WriteLine("The reverse is:" + rev);
        }
    }
}
