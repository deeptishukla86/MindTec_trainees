using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add(10);
           a1.Add("Deepti");
            a1.Add(34);
            a1.Add(679);
            a1.Add(908);
           // a1.Add(true);
            //Console.WriteLine(a1[0]);
           //Console.WriteLine(a1[1]);
            //Console.WriteLine(a1[2]);
            Console.WriteLine(a1.Capacity);

            Console.WriteLine(" \n");
            a1.Remove(10);
            a1.Remove(34);
            a1.Remove(679);
            a1.Remove (908);
            a1.Remove ("Deepti");
           Console.WriteLine(a1[0]);
           // Console.WriteLine(a1[1]);
            Console.WriteLine(a1.Capacity);

        }
    }
}
