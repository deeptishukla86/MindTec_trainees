using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 65, 66, 67, 68, 69 };
            char[] arr1 = new char[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = (char)arr[i];
                Console.Write(arr1[i] + "\t");
            }
            System.Console.ReadLine();
        }
    }
}
