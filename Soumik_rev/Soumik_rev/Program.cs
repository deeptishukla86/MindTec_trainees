using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soumik_rev
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, reverse = 0, rem;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            while(num>0)
            {
                rem = num % 10;
                reverse = (reverse * 10) + rem;
                num = num / 10;

            }

            Console.WriteLine("Reverse number is " + reverse);
            Console.ReadLine();
        }
    }
}
