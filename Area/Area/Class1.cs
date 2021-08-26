using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class Circle
    {
        float rad;
        public Circle (float r)
        {
            rad = r;
        }
        public void circle_area()
        {
            System.Console.WriteLine("Area of circle = " + (3.14 * rad * rad));
        }
    }
    public class Rhombus
    {
        float d1, d2;
        public Rhombus(float a, float b)
        {
            d1 = a;
            d2 = b;
        }
        public void R_area()
        {
            System.Console.WriteLine("Area of Rhombus = " + ((d1 * d2)/2) );
        }
    }
}
