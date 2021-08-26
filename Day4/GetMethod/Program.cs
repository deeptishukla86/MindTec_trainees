using System;

namespace GetMethod
{
    public class employee
    {
        
 
        private int _empid, _salary;
        private string _fname;
 
        public int empid
        {
            set
            {
                _empid = value;
 
            }
 
            get
            {
                return _empid;
            }
        }
        public int salary
        {
            set
            {
                _salary= value;
 
            }
 
            get
            {
                return _salary;
            }
        }
        public string fname
        {
            set
            {
                _fname = value;
 
            }
 
            get
            {
                return _fname;
            }
        }
        static void Main(string[] args)
        {
 
            employee e = new GetMethod.employee();
            e.empid = 101;
            e.salary = 2000;
            e.fname = "dd";
            Console.WriteLine("eployee details are {0},{1},{2}", e.empid, e.fname, e.salary);
        }
    }
}


