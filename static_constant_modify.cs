using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constant_exmp
{
    class Program
    {
        int a;
        static int b = 200;
        const float pi = 3.14f;
        readonly bool flag;
        public Program(int a, bool flag)
        {
            this.a = a;
            this.flag = flag;


        }
       
        

        static void Main(string[] args)
        {
            

        
            Console.WriteLine(Program.b);
            Console.WriteLine(Program.pi);
            Program p = new Program(50, true);
            Program p1 = new Program(100, false);
            Console.WriteLine(p.a + "" + p1.a);

            Console.WriteLine(p.flag + "" + p1.flag);
            p.a = 10;
            b = 12;
            Console.WriteLine("after modify:\n");
            Console.WriteLine(p.a + " " + b);
            


        }
    }


}
