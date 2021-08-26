using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areadll
{
    public class Class1
    {
        int radius, diagonal;
        public string areaCircle()
        {
            double area;
            Console.WriteLine("Enter radius of circle: ");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 3.14 * radius * radius;
            //Console.WriteLine(
            return "Area of circle is " + area;
            //);
        }
        public string areaRhombus()
        {
            double area;
            Console.WriteLine("Enter radius of rhombus: ");
            diagonal = Convert.ToInt32(Console.ReadLine());
            area = diagonal * diagonal / 2.0;
            //Console.WriteLine(
            return "Area of rhombus is " + area;
            //);
        }
    }
}
