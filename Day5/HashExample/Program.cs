using System;
using System.Collections;

namespace HashExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add("ID", 1001);
            h.Add("name", "Deepti");
            h.Add("salary", 200);
            h.Add("dept", "IT");
            foreach (object o in h.Keys)
            {
                Console.WriteLine(h[o]);
            }
            Console.WriteLine("Salary= " + h["salary"]);
            Console.WriteLine(h.ContainsValue(1001));



        }
    }

}
