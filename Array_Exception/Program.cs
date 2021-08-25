using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 2] { { 1, 2 }, {3 , 4 } };
            int[] arr2 = new int[4];
            int k = 0;
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                        arr2[k++] = arr1[i, j];
                }
                for(int i=0;i<4;i++)
                {
                    Console.Write(arr2[i]+"\t");
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
