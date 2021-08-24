using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sujaan_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number to be reversed: ");
            int i = Convert.ToInt32(System.Console.ReadLine());
            int a=1, b=0, x=i;
            while (x > 0)
            {
                b = b + a * (x % 10);
                x = x / 10;
                a = a * 10;
            }
            System.Console.WriteLine("The reverse of " + i + " is " + b);
            System.Console.ReadLine();
        }
    }
}
