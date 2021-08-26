using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculatearea;

namespace printarea_usingdll
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 c = new Class2();
            c.cir_area(7);
            c.romb_area(2, 3);
        }
    }
}
