using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryEmps
{
    public class Employee
    {
        public double salary;
    }
    public class Income : Employee
    {
        public double ta;
        public double da;
        public double hra;
        public double gross_tot;
        public void gross(double sal)
        {

            ta = sal * 0.1;
            da = sal * 0.1;
            hra = sal * 0.05;
            gross_tot = sal + ta + da + hra;

            Console.WriteLine("Gross salary: " + gross_tot);

        }


    }

    class Program
    {





        static void Main(string[] args)
        {
            Income emp1 = new Income();
            Income emp2 = new Income();

            Console.WriteLine("Enter basic salary of employee 1: ");
            emp1.salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter basic salary of employee 2: ");
            emp2.salary = Convert.ToDouble(Console.ReadLine());

            /* int emp1, emp2;
            Console.WriteLine("Enter basic salary of employee 1: ");
            emp1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter basic salary of employee 2: ");
            emp2 = Convert.ToInt32(Console.ReadLine());
           */

            /* emp1.ta = emp1.salary * 0.1;
             emp1.da = emp1.salary * 0.1;
             emp1.hra = emp1.salary * 0.05;
             Console.WriteLine("Gross salary: "+(emp1.salary+ emp1.ta + emp1.da + emp1.hra));
            */

            emp1.gross(emp1.salary);
            emp2.gross(emp2.salary);
            Console.ReadLine();





        }
    }
}