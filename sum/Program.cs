using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, sum;
            Console.WriteLine("Enter one integer: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another integer: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            sum = n1 + n2;
            Console.WriteLine("Sum is " + sum);
            Console.ReadLine();
        }
    }
}
