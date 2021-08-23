using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rem, s=0;
            Console.Write("Enter a number to reverse: ");
            n= Convert.ToInt32(Console.ReadLine());
            while(n!=0)
            {
                rem = n % 10;
                s = s * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("The reverse of the given number is "+s);
        }
    }
}
