using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


/*Write a Program to Print   your emp id, your name , project name, “Through the array list. If user enter empid in between 1001 to 1005 
Then Print “Yes you are in this project else “you are not in this batch”*/

namespace arraylist_example
{

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
           
            
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("emp_id");
                int e = 0;
                e = Convert.ToInt32(Console.ReadLine());
                a1.Add(e);
                Console.WriteLine("emp_Name:");
                string emp_name = " ";
                emp_name = Console.ReadLine ();
                a1.Add(emp_name);
                Console.WriteLine("project name:");
                string pr_name = " ";
                emp_name = Console.ReadLine();
                a1.Add(pr_name);
                if(e>1000 && e<1006)
                {
                    Console.WriteLine("yes u are in this project!!");
                }
                else
                {
                    Console.WriteLine("u are not in this batch");
                }






            }

        }
    }
}
