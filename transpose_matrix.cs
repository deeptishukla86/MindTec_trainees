using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transpose
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            int i, j;
            Console.WriteLine("enter the array elements:");
            for(i=0;i<2;i++)
            {
                for(j=0;j<2;j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());

                }

            }
            Console.WriteLine("Array :");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(a[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Transpose Array  :");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(a[j, i] + " ");

                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
    

