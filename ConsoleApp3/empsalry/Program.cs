using System;

namespace empsalry
{
   
     
        public class employee
        {
            public string name;
        }
        class salary:employee
        {
            public void print(float basic)
            {
                float TA = (basic * 10)/100;
                float Da = (basic * 10)/100;
                float HRA = (basic * 5)/100;
                float gross = basic + TA + Da + HRA;
                Console.WriteLine("Gross Salary is:" + gross);

            }
        
   
        
        static void Main(string[] args)
        {
                    salary p = new salary();
                    p.name = "Amit";
                    p.print(50000);

                   p.name="Raju";
            p.print(60000);



        }
    }
}
