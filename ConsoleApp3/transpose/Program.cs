using System;

namespace transpose
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3, 3];
            Console.WriteLine("enter a element");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)

                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("the array is");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("the Transpose is");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr1[j, i] + " ");
                }
                Console.WriteLine();


            }
        }
    }
}
