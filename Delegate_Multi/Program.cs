using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Multi
{
    public delegate void Circle_Prop(double r);
    public class Circle 
    { 
        public void GetDiameter(double r)
        {
        Console.WriteLine(@"Diameter is {0}", (2 * r));
        }
        public void GetArea(double r)
        {
            Console.WriteLine(@"Area is {0}", (3.14 * r * r));
        }
        public void GetCircumference(double r)
        {
            Console.WriteLine(@"Circumference is {0}", (2 * 3.14 * r));
        }
        static void Main(string[] args)
        {
            Circle cir = new Circle();
            Circle_Prop cirProp = new Circle_Prop(cir.GetArea);
            cirProp += cir.GetCircumference;
            cirProp += cir.GetDiameter;
            cirProp(5.5);
            Console.WriteLine();
            cirProp.Invoke(7);
            Console.WriteLine();
            //cirProp -= cir.GetDiameter;
            //Console.WriteLine();
            //cirProp.Invoke(7);
            cirProp -= cir.GetArea;
            cirProp(7);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
