using System;
using System.Collections;

namespace Collec
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            String x = "", y = "";
            int z = 0, n = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the ID of the employee :");
                z = Convert.ToInt32(Console.ReadLine());
                a.Add(z);
                Console.WriteLine("Enter the name of the employee :");
                x = Console.ReadLine();
                a.Add(x);
                Console.WriteLine("Enter the project name  :");
                y = Console.ReadLine();
                a.Add(y);
                Console.WriteLine(a[n]);
                Console.WriteLine(a[n + 1]);
                Console.WriteLine(a[n + 2]);
                if (z > 1000 && z < 1006)
                {
                    Console.WriteLine("“Yes you are in this project");
                }
                else
                {
                    Console.WriteLine("“You are not in this batch");
                }
            }
        }
    }
}