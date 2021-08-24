using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{

    class Basic_Salary
    {
        public float b;
        public void input()
        {
            System.Console.WriteLine("Enter basic salary:");
            b = float.Parse(Console.ReadLine());
            //return b;
        }
    }

    class FinalSalary : Basic_Salary
    {

        public void calculate()
        {
            input();
            float TA = (b * 10) / 100;
            float DA = (b * 10) / 100;
            float HRA = (b * 5) / 100;
            float gross = b + TA + DA + HRA;
            System.Console.WriteLine("Gross Salary is : " + gross);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FinalSalary s = new FinalSalary();
            //s.input();
            s.calculate();
            FinalSalary s2 = new FinalSalary();
            s2.calculate();

        }
    }
}