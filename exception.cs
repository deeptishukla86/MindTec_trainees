using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j,m;
            int[,] a = new int[,] { { 1, 2 }, { 3, 4 } };
            int[] b = new int[2];
            try
            {
                 m = 0;
                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        b[m++] = a[i, j];
                    }
                }
                foreach (var t in b)
                {
                    Console.WriteLine(t);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:\n "+e+"\n ");
                
            }
            finally
            {
                Console.WriteLine("End............!");
            }
            Console.ReadLine();
        }
    }
}
