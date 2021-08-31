using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentData
{
    class student
    {
        public string name { get; set; }
        public int maths { get; set; }
        public int science { get; set; }
        public int social { get; set; }
        public int english { get; set; }
        public int stat { get; set; }



        static void Main(string[] args)
        {
            student s1 = new student();
            {
                s1.name = "abhi";
                s1.maths = 70;
                s1.science = 85;
                s1.social = 90;
                s1.english = 80;
                s1.stat = 91;
            }
            student s2 = new student();
            {
                s2.name = "akash";
                s2.maths = 87;
                s2.science = 80;
                s2.social = 95;
                s2.english = 98;
                s2.stat = 96;
            }
            student s3 = new student();
            {
                s3.name = "bhanu";
                s3.maths = 88;
                s3.science = 95;
                s3.social = 90;
                s3.english = 84;
                s3.stat = 95;
            }

            Dictionary<Int16, student> dict = new Dictionary<Int16, student>();
            dict.Add(101,s1);
            dict.Add(102,s2);
            dict.Add(103,s3);
            Console.WriteLine("students details :");

            foreach (KeyValuePair<Int16, student> a in dict)
            {
                Console.WriteLine("Key = {0} : name={1} : maths={2} : science={3} : social={4} : engilsh={5} : stat{6} ", a.Key, 
                    a.Value.name, a.Value.maths, a.Value.science, a.Value.social, a.Value.english, a.Value.stat);
            }
            Console.WriteLine();
            Console.WriteLine("converting to array");

            student[] arr = new student[dict.Count];
            arr = dict.Values.ToArray();
            foreach(var o in arr)
            {
                Console.WriteLine(o.name);
                Console.WriteLine($"sub1 = {o.maths}");
                Console.WriteLine($"sub2 = {o.science}");
                Console.WriteLine($"sub3= {o.social}");
                Console.WriteLine($"sub4 = {o.english}");
                Console.WriteLine($"sub5 = {o.stat}");
                Console.WriteLine();


            }
            Console.WriteLine();
            Console.WriteLine("converting to dictionary again");
            var dictionary = arr.ToDictionary(x => Array.IndexOf(arr, x));
            foreach (KeyValuePair<Int16, student> a in dict)
            {
                Console.WriteLine("Key = {0} : name={1} : maths={2} : science={3} : social={4} : engilsh={5} : stat{6} ", a.Key,
                    a.Value.name, a.Value.maths, a.Value.science, a.Value.social, a.Value.english, a.Value.stat);
            }
            Console.WriteLine();
        }
    }
}
