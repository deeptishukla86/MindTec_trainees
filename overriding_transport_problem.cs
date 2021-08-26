using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_override
{
    class transport
    {
        public virtual void car(string name,int speed)
        {
            Console.WriteLine("transport system: " + name + " " + "speed:" + speed + " ");
        }
    }
    class threew : transport
    {
        public override void car(string name, int speed)
        {
            //base.car();
            Console.WriteLine("transport system: " + name + " " + "speed:" + speed + " ");
        }

    }
    class fourw : transport
    {
        public override void car(string name, int speed)
        {
           // base.car();
            Console.WriteLine("transport system: " + name + " " + "speed:" + speed + " ");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            transport t = new transport();
            t.car("train", 123);
            threew r = new threew();
            r.car("rikswa", 20);
            fourw f = new fourw();
            f.car("bolero", 2341);


        }
    }
}
