using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_sort_convert_array
{
    class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public int Maths { get; set; }
            public int Chemistry { get; set; }
            public int Biology { get; set; }

            public int Computer { get; set; }

            public int Physics { get; set; }
        }
        public static void Main()
        {
            Student s1 = new Student()
            {
                Name = "Amit",
                Maths = 90,
                Chemistry = 95,
                Biology = 85,
                Computer = 92,
                Physics = 90,
            };
            Student s2 = new Student()
            {
                Name = "Binod",
                Maths = 92,
                Chemistry = 93,
                Biology = 87,
                Computer = 89,
                Physics = 92,
            };
            Student s3 = new Student()
            {
                Name = "Chayan",
                Maths = 89,
                Chemistry = 93,
                Biology = 89,
                Computer = 95,
                Physics = 84,
            };
            Student s4 = new Student()
            {
                Name = "Debartha",
                Maths = 95,
                Chemistry = 85,
                Biology = 85,
                Computer = 95,
                Physics = 90,
            };
            Student s5 = new Student()
            {
                Name = "Rohit",
                Maths = 80,
                Chemistry = 85,
                Biology = 95,
                Computer = 92,
                Physics = 85,
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
                Console.WriteLine("Key={0}, Name = {1},Maths = {2},  Chemistry = {3}, Biology = {4}, Computer = {5}, Physics = {6} ",
                    students.Key, students.Value.Name, students.Value.Maths, students.Value.Chemistry, students.Value.Biology, students.Value.Computer, students.Value.Physics);
            }
            Console.WriteLine("Employees After sorting");
            foreach (KeyValuePair<Int16, Student> students in s.OrderBy(key => key.Value.Maths))
            {
                Console.WriteLine("Key={0}, Name = {1},Maths = {2},  Chemistry = {3}, Biology = {4}, Computer = {5}, Physics = {6} ",
                    students.Key, students.Value.Name, students.Value.Maths, students.Value.Chemistry, students.Value.Biology, students.Value.Computer, students.Value.Physics);
            }
            Student[] stu = new Student[s.Count];
            stu = s.Values.ToArray();
            foreach (var item in stu)
            {
                Console.WriteLine("Name :" + item.Name);
                Console.WriteLine("Maths :" + item.Maths);
                Console.WriteLine("Chemistry :" + item.Chemistry);
                Console.WriteLine("Biology :" + item.Biology);
                Console.WriteLine("Computer :" + item.Computer);
                Console.WriteLine("Physics :" + item.Physics);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
