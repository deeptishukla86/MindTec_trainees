using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Transaction
{
    public class Bank
    {
        public void transaction(int bal)
        {
            int bal1 = 0;
            while (bal >= 0)
            {
                Console.WriteLine("Enter the amount that you want to debit: ");
                int amount = int.Parse(Console.ReadLine());
                if (amount <= bal)
                {
                    bal1 = bal - amount;
                    Console.WriteLine("Amount debited successfully , remaining balence is :" + bal1);

                }
                else
                {
                    throw (new Balance("Insufficient Balence :"));
                }
                bal = bal - amount;
            }
        }
    }
    class Balance : Exception
    {
        public Balance(string Msg) : base(Msg)
        {

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount you want to credit :");
            int bal = int.Parse(Console.ReadLine());
            Bank b = new Bank();
            try
            {
                b.transaction(bal);

            }
            catch (Balance e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
