using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[4]{ 65,66,67,68};
            char[] c = new char[4];
            for (int i = 0; i < 4; i++)
            {
                c[i] = (char)A[i];
                Console.WriteLine(c[i]);
            }
            Console.ReadLine();


        }
    }
}
