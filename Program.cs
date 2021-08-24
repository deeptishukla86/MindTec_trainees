using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stat_Var
{
    
    class Area
    {
        public float area,length, breadth, side, radius;
        public virtual void display()
        {
            Console.Write("The Area Of The ");
        }

    }
    class Square : Area
    {
        public override void display()
        {
            base.display();
            Console.Write("Square is: ");
            area = side * side;
            Console.WriteLine(area);
        }
    }
    class Rectangle : Area
    {
        public override void display()
        {
            base.display();
            Console.Write("Rectangle is: ");
            area = breadth * length;
            Console.WriteLine(area);
        }
    }
    class Circle : Area
    {
        public override void display()
        {
            base.display();
            Console.Write("Circle is: ");
            area = (3.14f * radius * radius);
            Console.WriteLine(area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square();
            Rectangle r = new Rectangle();
            Circle c = new Circle();
            Console.WriteLine("Enter the side of the square: ");
            s.side = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length & breadth of the rectangle: ");
            r.length= int.Parse(Console.ReadLine());
            r.breadth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the radius of the square: ");
            c.radius = int.Parse(Console.ReadLine());
            s.display();
            r.display();
            c.display();
            Console.ReadLine();
        }
    }
}
