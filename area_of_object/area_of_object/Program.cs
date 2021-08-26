using System;
using dll_area;

namespace area_of_object
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the two diagonals of rombus: ");
            double d1 = Convert.ToDouble(Console.ReadLine());
            double d2 = Convert.ToDouble(Console.ReadLine());
            var c = new Class1();
            var r = new class2();
            c.area_circle(radius);
            r.area_rombus(d1, d2);
        }
    }
}
