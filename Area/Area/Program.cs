using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class area1
    {
        public virtual void cal()
        {
            Console.Write("Enter side of square: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of square is " + a * a);

        }
    }

    public class area2: area1
    {
        public override void cal()
        {
            base.cal();
            Console.WriteLine("Enter length and breadth: ");
            int l = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of square is " + (l * b));
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            area1 obj = new area2();

            obj.cal();
           

        }
    }
}
