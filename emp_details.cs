using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class emp
    {

        public void empl(string emp_name)
        {
            Console.WriteLine("employee_ name:"+emp_name+" ");
        }

    }

    class salary : emp
    {
        private int  da, ta, hra, gs;
        public void sal_cal(int bs)
        {
            ta = (bs * 10) / 100;
            da = (bs * 10) / 100;
            hra = (5 * bs) / 100;
            gs = bs + ta + da + hra;
            Console.WriteLine("gross salary:" + gs + " ");



        }

    }
       
 
    
    class Program
    {
        static void Main(string[] args)
        {
            salary e1 = new salary();
            salary e2 = new salary();
            e1.empl("tri");
            e1.sal_cal(50000);
            e2.empl("xyz");
            e2.sal_cal(30000);

            Console.ReadLine();
        }
    }
}
