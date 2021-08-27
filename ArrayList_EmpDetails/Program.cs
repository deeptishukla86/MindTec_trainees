using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList_EmpDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Enter Your Emp_Id: ");
            int p = int.Parse(Console.ReadLine());
            al.Add(p);
            Console.WriteLine("Enter Your Name: ");
            string a = Convert.ToString(Console.ReadLine());
            al.Add(a);
            Console.WriteLine("Enter Your Project Name: ");
            string b = Convert.ToString(Console.ReadLine());
            al.Add(b);
            if (p > 1000 && p < 1006)
            {
                Console.WriteLine("You are in the project");
                Console.WriteLine("Your project details is \nEmployee Id:{0}\nName:{1}\nProject Name:{2}", p, a, b);
            }
            else
                Console.WriteLine("You are not in the project");
            Console.Read();
        }
    }
}
