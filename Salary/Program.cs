using System;

namespace ConsoleApp8
{
    public class employee
    {
        public float basic, ta, hra, da;
        public String name;
    }
    public class emp : employee
    {
        float gross;
        public void grosal(float b)
        {
            ta = (b * 10) / 100;
            hra = (b * 50) / 100;
            da = (b * 10) / 100;
            gross = b + ta + hra + da;
            Console.WriteLine("Gross salary=" + " " + gross);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            emp e = new emp();
            Console.WriteLine("Enter employee name:");
            e.name = Console.ReadLine();
            Console.WriteLine("Enter basic salary:");
            e.basic = Convert.ToInt32(Console.ReadLine());
            e.grosal(e.basic);
        }
    }
}
