using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_area
{
    public class Class1
    {
        public  void area_circle(double radius ) 
        {
            double a1 = 3.14 * radius * radius;
            Console.WriteLine("area of circle is: "+a1);
        }
       
    }
    public class class2
    {
        public void area_rombus(double d1, double d2)
        {
            double a2 = (d1 * d2)/2;
            Console.WriteLine("area of rombus is :"+a2);
        }
    }
}
