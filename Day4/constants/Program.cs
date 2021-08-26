using System;

namespace constants
{
    class Program
    {
        int a;
        static int b = 20;
        const int c = 10;
        const float pi = 3.14f;
        readonly  bool flag ;
        public Program(int a, bool flag)
        {
            this.a = a;
            this.flag = flag;


        }
        public void print()
        {
            
            Console.WriteLine("area of square :" + c);
            Console.WriteLine();
        }
        public void add()
        {
            Console.WriteLine("area " + pi);
        }


        static void Main(string[] args)
        {
            
            Program p = new Program(50, true);
            //Program p1 = new Program(100, false);

            Console.WriteLine(p.a + "" + p.flag);
            //Console.WriteLine(p.flag + "" + p1.flag);

            p.print();
            p.add();
        }
    }
}


