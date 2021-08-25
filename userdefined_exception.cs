using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userdefined_exc
{
    public class bank
    {
      

        public void cal(double balance)
        {
            double bal = 0.0;
            while(balance!=0)
            {
                Console.WriteLine("enter the amont that u want to debit:");
                double amn = Convert.ToInt32(Console.ReadLine());

                if (amn <=balance)
                {
                    bal = balance - amn;
                    Console.WriteLine("!!......AMOUNT DEBITED SUCCESFULLY......!!");
                    Console.WriteLine("REMAINING BALANCE:  "+bal+" ");

                }
                else
                {
                    throw (new account("!!!!............INSUFFICIENT BALANCE..........!!!!"));
                }
                balance = balance - amn;
            }
            
        }
    }
    public class account: Exception
    {
        public account(string Msg) : base(Msg)
    {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the amount.....:");
            double bal = Convert.ToInt32(Console.ReadLine());
            bank b = new bank();
            try
            {
                b.cal(bal);
            }
            catch(account e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}




