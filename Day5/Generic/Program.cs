using System;
using System.Collections.Generic;
namespace Generic
{
    class pRO
    {
        public class SortByName : IComparer<Emp>
        {
            public int Compare(Emp x, Emp y)
            {
                return x.name.CompareTo(y.name);
            }
        }
        public class Emp
        {

            public int id { get; set; }
            public string name { get; set; }
            public double salary { get; set; }


        }


        class Program
        {
            static void Main(string[] args)
            {
                Emp E1 = new Emp();
                {
                    E1.id = 101;
                    E1.name = "abhi";
                    E1.salary = 50000;
                }
                Emp E2 = new Emp();
                {
                    E2.id = 102;
                    E2.name = "banu";
                    E2.salary = 60000;
                }
                Emp E3 = new Emp();
                {
                    E3.id = 103;
                    E3.name = "akash";
                    E3.salary = 70000;
                }

                List<Emp> list = new List<Emp>();
                list.Add(E1);
                list.Add(E2);
                list.Add(E3);
                Console.WriteLine("Employees before sorting");

                foreach (var obj in list)
                {
                    Console.WriteLine("Id={0},name={1},salary={2}", obj.id, obj.name, obj.salary);
                }

                SortByName sort = new SortByName();
                list.Sort(sort);
                Console.WriteLine("Employees After sorting");
                foreach (var obj in list)
                {
                    Console.WriteLine("Id={0},name={1},salary={2}", obj.id, obj.name, obj.salary);
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}
