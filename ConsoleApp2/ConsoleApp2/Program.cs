using System;

namespace ConsoleApp2
{
    public class first
    {
        public virtual void print(int a)
        {
            a = a * a;
        }
        public virtual void calc(float b,float c)
        {
            float area = (b * c) / 2;
        }
    }
    public class second : first
    {
        public override void print(int a)
        {
            a = a * a;
            Console.WriteLine("Area of square is: " + a);
            Console.WriteLine();
        }
        public override void calc(float b, float c)
        {
            float area = (b * c) / 2;
            Console.WriteLine("area of triangle is : " + area);
        }

        static void Main(string[] args)
        {
            first s = new second();
            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            s.print(a);

            Console.WriteLine("enter breadth :");
            float b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter height :");
            float c = Convert.ToInt32(Console.ReadLine());

            s.calc(b, c);

        }
    }
}
