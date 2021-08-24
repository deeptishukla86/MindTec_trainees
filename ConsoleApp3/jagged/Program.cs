using System;

namespace jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr= new int[2][];
            arr[0] = new int[] { 10, 20, 30 };
            arr[1] = new int[] { 11, 12, 13, 14, 15 };
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr[i].Length;j++)
                {
                    Console.Write(arr[i][j] + " ");
                    
                }
                Console.WriteLine();
            }
            
        }
    }
}
