using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =new int[4] { 65, 66, 67, 68 };
            char[] a=new char[4];
            for (int i=0; i<arr.Length; i++)
            {
                a[i] = (char)arr[i];
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}
