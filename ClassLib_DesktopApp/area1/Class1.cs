using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Class1
    {
        public double area;
        public double cir(double n)
        {
            area = (3.14f * n * n);
            return area;
        }
        public double rom(double m, double p)
        {
            area = (m * p)/2;
            return area;
        }

    }
}
