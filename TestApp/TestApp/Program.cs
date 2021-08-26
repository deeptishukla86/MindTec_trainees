using System;
using Area;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaCircle ac = new AreaCircle();
            Console.WriteLine("Enter the radius of circle: ");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of circle: " + ac.Circle(r1));

            AreaRhombus ar = new AreaRhombus();
            Console.WriteLine("Enter the Diaginal p of Rhombus: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Diaginal q of Rhombus: ");
            double q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of circle: " + ar.Rhombus(p, q));
        }
    }
}
