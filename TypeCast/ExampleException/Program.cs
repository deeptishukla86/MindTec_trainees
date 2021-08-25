using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int temp = 0;
            int[] arr1 = new int[6];

            try
            {
                Console.WriteLine("2d array elements : ");
                 for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine("a[{0},{1}]= {2}", i, j, arr[i, j]);
                    }
                }
                Console.WriteLine("1d array elements :");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arr1[temp++] = arr[i, j];
                    }
                }
                for (int i = 0; i < 2 * 3; i++)
                {
                    Console.WriteLine("{0}\t", arr1[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.Write("welcome");
            }


        }
    }
}
