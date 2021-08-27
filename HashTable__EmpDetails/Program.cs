using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable__EmpDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hs = new Hashtable();
            Console.WriteLine("Enter Your Emp_Id: ");
            int a = int.Parse(Console.ReadLine());
            hs.Add("Emp-Id:", a);
            Console.WriteLine("Enter Your Name: ");
            hs.Add("Emp_Name:", Convert.ToString(Console.ReadLine()));
            Console.WriteLine("Enter Your Project Name: ");
            hs.Add("Project Name:", Convert.ToString(Console.ReadLine()));
            if (a > 1000 && a < 1006)
            {
                Console.WriteLine("You are in the project");
                Console.WriteLine("Your project details is \nEmployee Id:{0}\nName:{1}\nProject Name:{2}", hs["Emp-Id:"], hs["Emp_Name:"], hs["Project Name:"]);
            }
            else
                Console.WriteLine("You are not in the project");
            Console.Read();
        }
    }
}
