using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emplyoee1
{
    class Program
    {
        public class Student
        {
            public int s_id { get; set; }
            public string Name { get; set; }
            public string subject { get; set; }
            public int marks { get; set; }
            public string cls { get; set; }

        }
        static void Main(string[] args)
        {

            Student s1 = new Student()
            {
                s_id = 101,
                Name = "xyz",
                subject = "Maths",
                marks = 80,
                cls="xi"
            };
            Student s2 = new Student()
            {
                s_id = 102,
                Name = "Pranaya",
                subject = "phy",
                marks = 180,
                cls = "xii"
            };
            Student s3 = new Student()
            {
                s_id = 103,
                Name = "abc",
                subject = "chem",
               marks = 100,
                cls = "xiv"
            };
            Student s4 = new Student()
            {
                s_id = 104,
                Name = "Pra",
                subject = "cs",
               marks = 70,
                cls = "x"
            };
            Student s5 = new Student()
            {
                s_id = 105,
                Name = "anaya",
                subject = "ben",
                marks = 200,
                cls = "xi"
            };
            Dictionary<Int16, Student> s = new Dictionary<Int16, Student>();
            s.Add(1, s1);
            s.Add(2, s2);
            s.Add(3, s3);
            s.Add(4, s4);
            s.Add(5, s5);
            Console.WriteLine("Student Details :");
            Console.WriteLine();
            foreach (KeyValuePair<Int16, Student> students in s)
            {
                Console.WriteLine("Key={0}, Name = {1},subject= {2},  marks = {3}, cls = {4} ",
                    students.Key, students.Value.Name, students.Value.subject, students.Value.marks, students.Value.cls);
            }
            Console.ReadKey();



        }
    }
}
