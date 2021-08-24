using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

    
            static void Main(string[] args)
            {
                
                Console.WriteLine("Enter n: ");
                int n = Convert.ToInt32(Console.ReadLine());
                for(int j=1;j<n;j++)
                {
                    for (int i = 0; i <=j;i++)
                    {
                        Console.WriteLine("*");
                        Console.WriteLine();
                    }
                }
                Console.ReadLine();

            }
        }
    }

}
 
