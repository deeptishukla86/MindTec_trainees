using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arr[i, j] = [i, j];
                        Console.Write("2D Array Elements : " + arr[i, j]);
                    }
                    Console.WriteLine();
                }
                int temp = 0;
                int[] arr1 = new int[6];

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arr1[temp] = arr[j, i];
                        temp++;
                    }
                }
                Console.WriteLine("1d array elements :");
                for (int i = 0; i < arr1.Length; i++)
                {
                    Console.Write(arr1[i] + " ");
                }
                Console.WriteLine();

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
