using System;

namespace Transpose
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 3] { {1, 2, 3}, {4, 5, 6} };
            int[,] arr2 = new int[3, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr2[j, i] = arr1[i, j];
                }
            }
            Console.WriteLine("Transposed Array: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0} ", arr2[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
