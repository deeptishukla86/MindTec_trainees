using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee
    {
        public String Emp_name1 = "Ajay Dey";
        public String Emp_name2 = "Anirban Dutta";

        public static double Emp_salary1 = 50000;
        public static double Emp_salary2 = 60000;
    }

    public class Total : Employee
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
            Total s = new Total();
            Console.WriteLine("Employee 1 Gross Salar" + " " + s.Gross1);
            Console.WriteLine("Employee 1 Gross Salar" + " " + s.Gross2);
            Console.ReadLine();
        }
        
    }
}
