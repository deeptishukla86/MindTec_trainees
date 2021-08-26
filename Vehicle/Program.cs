using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        public string name, colour, mileage, topspeed;

        public virtual void spec()
        {
            Console.WriteLine("Enter the name of the vehicle: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the colour of the vehicle: ");
            colour = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the milage of the vehicle: ");
            mileage = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the topspeed of the vehicle: ");
            topspeed = Convert.ToString(Console.ReadLine());
        }
        public virtual void display()
        {
            Console.WriteLine("The name of the " + colour + " colour vehicle is: " + name + " which having top speed of " + topspeed + " & giving a mileage of " + mileage + "km/ltr\n");
        }
    }
    class Four_Wheeler : Vehicle
    {
        public override void spec()
        {
            Console.WriteLine("Enter the name of the Four_Wheeler: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the colour of the Four_Wheeler: ");
            colour = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the mileage of the Four_Wheeler: ");
            mileage = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the topspeed of the Four_Wheeler: ");
            topspeed = Convert.ToString(Console.ReadLine());
        }
        public override void display()
        {
            Console.WriteLine("The name of the " + colour + " colour four wheeler is " + name + " which having top speed of " + topspeed + " & giving a mileage of " + mileage + "km/ltr\n");
        }
    }
    class Two_Wheeler : Vehicle
    {
        public override void spec()
        {
            Console.WriteLine("Enter the name of the Two_Wheeler: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the colour of the Two_Wheeler: ");
            colour = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the mileage of the Two_Wheeler: ");
            mileage = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the topspeed of the Two_Wheeler: ");
            topspeed = Convert.ToString(Console.ReadLine());
        }
        public override void display()
        {
            Console.WriteLine("The name of the " + colour + " colour two wheeler is " + name + " which having top speed of " + topspeed + " & giving a mileage of " + mileage + "km/ltr");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle fw = new Four_Wheeler();
            fw.spec();
            fw.display();
            Vehicle tw = new Two_Wheeler();
            tw.spec();
            tw.display();
            Console.ReadLine();
        }
    }
}
