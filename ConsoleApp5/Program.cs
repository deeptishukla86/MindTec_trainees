using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Employee
    {
            public double basic, ta, da, hra;
    }
    class Developer : Employee
    {
        public double gross;
        
        public void calc()
        {
            ta = 0.1 * basic;
            da = 0.1 * basic;
            hra = 0.05 * basic;
            gross = basic + ta + da + hra;
        }
    }
    class Runner
    {
        static void Main(string[] args)
        {
            Developer dev1 = new Developer();
            Console.WriteLine("Enter basic of Developer 1: ");
            dev1.basic = Convert.ToDouble(Console.ReadLine());
            Developer dev2 = new Developer();
            Console.WriteLine("Enter basic of Developer 1: ");
            dev2.basic = Convert.ToDouble(Console.ReadLine());
            dev1.calc();
            dev2.calc();
            Console.WriteLine("Gross Salary of Developer 1 is " + dev1.gross);
            Console.WriteLine("Gross Salary of Developer 2 is " + dev2.gross);
            Console.ReadLine();
        }
    }
}
