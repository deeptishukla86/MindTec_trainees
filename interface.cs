using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    interface inter
    {
        void even();
        void odd();


    }





    public class exe : inter
    {

        public void even()
        {
            Console.WriteLine("\n");
            Console.WriteLine("this is even");
            Console.WriteLine("this is two");
            Console.WriteLine("this is four");

        }
        public void odd()
        {
            Console.WriteLine("this is one");
            Console.WriteLine("this is three");
            Console.WriteLine("this is five");

        }
       
    }



    class Program
    {

        static void Main(string[] args)
        {
            exe t = new exe();

            t.odd();
            t.even();
            
            Console.ReadLine();

        }
    }
}

