using System;

namespace salary
{
    class Employee
    {
        public string name;
        public float basic;
        public float ta, hra, da, pf;
    }

    class EmpSalary : Employee
    {
        float gross;
        public void calculate()
        {
            ta = (10 * basic) / 100;
            hra = (15 * basic) / 100;
            da = (30 * basic) / 100;
            pf = (12 * basic) / 100;
            gross = basic + ta + hra + da - pf;
        }

        public void display()
        {
            Console.WriteLine("Employee Basic pay: " + basic);
            Console.WriteLine("Employee TA: " + ta);
            Console.WriteLine("Employee HRA: " + hra);
            Console.WriteLine("Employee DA: " + da);
            Console.WriteLine("Employee PF: " + pf);
            Console.WriteLine("Employee Gross pay: " + gross);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmpSalary emp1 = new EmpSalary();
            EmpSalary emp2 = new EmpSalary();
            Console.Write("Emter Employee1 name: ");
            emp1.name = Console.ReadLine();
            Console.Write("Enter basic pay of emp1: ");
            emp1.basic = (float)Convert.ToDouble(Console.ReadLine());
            emp1.calculate();
            emp1.display();
            Console.WriteLine();
            Console.Write("Emter Employee2 name: ");
            emp2.name = Console.ReadLine();
            Console.Write("Enter basic pay of emp2: ");
            emp2.basic = (float)Convert.ToDouble(Console.ReadLine());
            emp2.calculate();
            emp2.display();
        }
    }
}
