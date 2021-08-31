using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multicast_delegate
{
    using System;

    namespace Circle
    {
        public delegate void circle(int r);
        class Program
        {
            public void diameter(int r)
            {
                Console.WriteLine("Diameter of circle " + (2 * r));
            }

            public void circum(int r)
            {
                Console.WriteLine("Circumference of Circle " + (2 * 3.14 * r));
            }

            public void area(int r)
            {
                Console.WriteLine("Area of Circle " + (3.14 * r * r));
            }
            static void Main(string[] args)
            {
                Program program = new Program();
                circle c = new circle(program.diameter);
                int r = Convert.ToInt32(Console.ReadLine());
                // Circum
                c -= program.diameter;
                c += program.circum;
                c(r);
                // Area
                c -= program.circum;
                c += program.area;
                c(r);

                //diameter
                c -= program.area;
                c += program.diameter;
                c(r);
            }
        }
    }
}
