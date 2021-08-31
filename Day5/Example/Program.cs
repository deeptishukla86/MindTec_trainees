using System;
using System.Collections;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("enter empid");
                int id = Convert.ToInt32(Console.ReadLine());
                arr.Add(id);
                Console.WriteLine("enter name");
                string name = (Console.ReadLine());
                arr.Add(name);
                Console.WriteLine("enter project name");
                string project = Console.ReadLine();
                arr.Add(project);

                if (id > 1000 && id <= 1005)
                {
                    Console.WriteLine("yes you are in the project");
                    foreach (object obj in arr)
                    {
                        Console.WriteLine(obj + " ");
                    }
                }
                else
                {
                    Console.WriteLine(" not in project");
                }
                

            }
        }
    }
}
