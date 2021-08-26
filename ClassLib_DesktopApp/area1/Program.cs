using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circle;

namespace area1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the diagonals of the rhombus");
            double q = Convert.ToDouble(Console.ReadLine());
            double r = Convert.ToDouble(Console.ReadLine());
            Class1 c = new Class1();
            Console.WriteLine("The Area Of Circle: " + c.cir(p));
            Console.WriteLine("The Area Of Rhombus: " + c.rom(q,r));
            Console.ReadLine();
        }
    }
}
