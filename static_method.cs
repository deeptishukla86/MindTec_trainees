using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examplestatic
{
    class Program
    {
        public static void add(int a ,int b)
        {

            Console.WriteLine("sum:" + (a + b));


        }
        public static void sub(int a,int b)
        {

            Console.WriteLine("sub:" + (a - b));

        }
        public static void multiply(int a, int b)
        {

            Console.WriteLine("multi:" + (a * b));

        }
        public static void div(int a,int b)
        {

            Console.WriteLine("div:" + (a / b));

        }
        static void Main(string[] args)
        {
            add(2, 2);
            sub(2, 2);
            multiply(2, 2);
            div(2, 2);
            Console.ReadLine();
        }
    }
}
