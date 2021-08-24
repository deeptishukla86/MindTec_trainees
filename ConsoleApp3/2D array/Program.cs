using System;

namespace _2D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];
            arr[0, 1] = 10;
            arr[1, 0] = 20;
            //   arr[2, 3] = 30;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(arr[i, j] + "");
                }

            }

        }
    }
}
