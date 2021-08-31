using System;

namespace ExampleDelegates
{
    public delegate void circle(int r);
    class Program
    {
        public void diameter(int r)
        {
            Console.WriteLine("diameter of a circle is :" + (2 * r));
        }
        public void area(int r)
        {
            Console.WriteLine("area  of a circle is :" + (2 *3.14* r));

        }
        public void cirumstance(int r)
        {
            Console.WriteLine("circumstance  of a circle is :" + (3.14* r*r));

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("enter the radius of circle :");
            int r = Convert.ToInt32(Console.ReadLine());
            circle c = new circle(p.area); //area
            c(r);
            Console.WriteLine();
            c += p.diameter; //diameter
            c += p.cirumstance; //circumstance
            c(r);
            Console.WriteLine();
            c -= p.area;
            c += p.area;
            c(r);
        }
    }
}
