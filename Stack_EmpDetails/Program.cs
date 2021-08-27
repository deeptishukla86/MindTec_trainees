using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack_EmpDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            Console.WriteLine("WELCOME TO MINDTECK\n");
            Console.WriteLine("Enter Your Emp_Id: ");
            int a = int.Parse(Console.ReadLine());
            if (a > 1000 && a < 1006)
            {
                s.Push(a);
                Console.WriteLine("Enter Your Name: ");
                string n = Convert.ToString(Console.ReadLine());
                s.Push(n);
                Console.WriteLine("Enter Your Project Name: ");
                string p = Convert.ToString(Console.ReadLine());
                s.Push(p);
                Console.WriteLine();
                Console.WriteLine("You are in the Mindteck project");
                Console.WriteLine("Your project details is \nEmployee Id:{0}\nName:{1}\nProject Name:{2}", a, n, p);
            }
            else
                Console.WriteLine("You are not in the project. Invalid EmpId!!!!!");
            Console.Read();
        }
    }
}
