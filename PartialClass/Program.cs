using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            Partialdemo p = new Partialdemo();
            p.fname = "Surajit";
            p.lname = "Bardhan";
            p.displaydata();
            Console.ReadLine();
        }
    }
}
