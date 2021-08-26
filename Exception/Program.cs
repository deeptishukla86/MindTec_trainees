using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[] b = new int[5];
            try
            {
                //b = a;
                int x = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        b[x++] = a[i, j];
                    }
                }
                foreach (int element in b)
                {
                    Console.WriteLine(element);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
