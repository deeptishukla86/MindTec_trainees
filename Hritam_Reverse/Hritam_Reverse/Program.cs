using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hritam_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
			int num;
			int reverse = 0;

			Console.WriteLine("Enter the number : ");
			num = int.Parse(Console.ReadLine());

			while (num > 0)
			{
				reverse = reverse * 10 + num % 10;
				num = num / 10;
			}

			Console.WriteLine("Reversed number : " + reverse);
			Console.ReadKey();
		}
    }
}
