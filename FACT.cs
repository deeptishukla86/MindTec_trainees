using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, f = 1, n;
            Console.WriteLine("Enter the value of n:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=1;i<=n;i++)
            {
                f = f * i;
            }
            Console.WriteLine("Factorial of " +n +": "+f);
            Console.ReadLine();
        }
    }
}
