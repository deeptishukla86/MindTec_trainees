using System;

namespace Area
{
    public class Reactangle
    {
        public int a, b;
        public virtual int getArea()
        {
            return a * b;
        }
    }
    public class Square : Reactangle
    {
        public int m;
        public override int getArea()
        {
            base.getArea();
            return m * m;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square();
            Console.WriteLine("Enter the length of the side of square: ");
            sq.m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sq.getArea());
            Console.WriteLine();
            Reactangle rec = new Reactangle();
            Console.WriteLine("Enter Length: ");
            rec.a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            rec.b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(rec.getArea());
        }
    }
}
