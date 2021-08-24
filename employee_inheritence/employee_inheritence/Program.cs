using System;

namespace employee_inheritence
{
    public class employee
    {
        public int basic;
        public int TA, DA, HRA;
    }
    public class emp1 : employee
    {
        public string name; 
        public void calculate()
        {
            TA = basic / 10;
            DA = basic / 10;
            HRA = basic / 10;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            emp1 e1 = new emp1();

            Console.WriteLine("enter name of employee: ");
            e1.name = Console.ReadLine();

            Console.WriteLine("enter basic of employee: ");
            e1.basic = Convert.ToInt32(Console.ReadLine());        
            e1.calculate();
            Console.WriteLine(e1.name+" has gross salary= "+(e1.DA+e1.TA+e1.HRA+e1.basic));
        }
    }
}
