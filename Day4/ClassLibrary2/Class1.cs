using System;

namespace ClassLibrary2
{
    public class Class1
    {
        
        public void circle()
        {
            Console.WriteLine("enter radius of circle :");
            int r = Convert.ToInt32(Console.ReadLine());
            double A = (3.14)*r*r;
            Console.WriteLine("area of circle is : " + A);
            

        }

        public void rhombus()
        {
            Console.WriteLine("enter value of 1 diagonal");
            int d1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of 2 diagonal");
            int d2 = Convert.ToInt32(Console.ReadLine());

            double r = (d1 * d2) / 2;
            Console.WriteLine("area of rhombus is : " + r);
            Console.ReadLine();

        }
    }
}
