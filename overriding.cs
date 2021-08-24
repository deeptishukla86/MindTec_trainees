using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overr
{
    public class base1
    {
        int a=2;
   
        public virtual void area()
        {
            Console.WriteLine("area of square:" + (a * a));

        }
    }
    public class child : base1
    {
        int a=2, b=3;
        public override void area()
        {
            base.area();

            Console.WriteLine("area of rectangle is " + (a * b));

        }

        class Program
        {
            static void Main(string[] args)
            {
                child c = new child();
                c.area();
                Console.ReadLine();
            }
        }
    }
}
