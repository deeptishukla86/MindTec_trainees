using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee
    {

        public String Emp1;
        public String Emp2;
        public static double Emp_salary1 = 30000;
        public static double Emp_salary2 = 50000;
    }

    public class emp : Employee
    {
        public static double ta1 = 0.1 * Emp_salary1;
        public static double ta2 = 0.1 * Emp_salary2;
        public static double da1 = 0.1 * Emp_salary1;
        public static double da2 = 0.1 * Emp_salary2;
        public static double hra1 = 0.05 * Emp_salary1;
        public static double hra2 = 0.05 * Emp_salary2;
        public double Gross1 = Emp_salary1 + ta1 + da1 + hra1;
        public double Gross2 = Emp_salary2 + ta2 + da2 + hra2;

    }
    class Program
    {
        static void Main(string[] args)
        {
            emp s = new emp();
            Console.WriteLine("Enter emp1 name");
            s.Emp1 = Console.ReadLine();
            Console.WriteLine("Enter emp2 name");
            s.Emp2 = Console.ReadLine();
            Console.WriteLine("Employee 1 Gross Salary" + " " + s.Gross1);
            Console.WriteLine("Employee 1 Gross Salary" + " " + s.Gross2);
            Console.ReadLine();
        }

    }
}