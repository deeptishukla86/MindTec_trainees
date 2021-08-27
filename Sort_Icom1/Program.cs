using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Icom1
{
    class Program
    {
        public class SortByName : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)
            {
                return x.salary.CompareTo(y.salary);
            }
        }
        public class Employee
        {
            public int emp_id { get; set; }
            public string name { get; set; }
            public double salary { get; set; }
        }
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                emp_id = 100,
                name = "Bifauxen",
                salary = 20000
            };
            Employee emp2 = new Employee()
            {
                emp_id = 101,
                name = "Mark",
                salary = 10000
            };
            Employee emp3 = new Employee()
            {
                emp_id = 102,
                name = "Warewolf",
                salary = 30000
            };
            List<Employee> employees = new List<Employee>();
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            Console.WriteLine("Employees before sorting salarywise\n");
            foreach (var emp in employees)
            {
                Console.WriteLine("Employee Id: {0}", emp.emp_id);
                Console.WriteLine("Employee Name: {0}", emp.name);
                Console.WriteLine("Employee Salary: {0}", emp.salary);
                Console.WriteLine();
            }
            SortByName sortByName = new SortByName();
            employees.Sort(sortByName);
            Console.WriteLine("Employees After sorting salarywise\n");
            foreach (var emp in employees)
            {
                Console.WriteLine("Employee Id: {0}", emp.emp_id);
                Console.WriteLine("Employee Name: {0}", emp.name);
                Console.WriteLine("Employee Salary: {0}", emp.salary);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
