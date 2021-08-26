using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Area;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            Rhombus rh = new Rhombus(10, 15);
            c.circle_area();
            rh.R_area();
        }
    }
}
