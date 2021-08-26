using System;

namespace methodExam
{
    public class Program
    {
        public void display()
        {
            Console.WriteLine("base class");
        }
    }
    public class fun:Program
    {
        public void display()
        {
            Console.WriteLine("derived class");
        }

    }
    class pr { 
        static void Main(string[] args)
        {
            fun cs = new fun();
            cs.display();
        }
    }
}
