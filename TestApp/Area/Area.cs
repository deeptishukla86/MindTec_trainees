using System;

namespace Area
{
    public class AreaCircle
    {
        public const double PI = 3.1415926535897931;
        public double Circle(double r)
        {
            return PI * r * r;
        }
    }
    public class AreaRhombus
    {
        public double Rhombus(double p, double q)
        {
            return (p * q) / 2;
        }
    }
}
