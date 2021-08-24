using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static string[] ar = new string[] { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
        static void Main(string[] args)
        {
            
         
            foreach (var i in ar)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
