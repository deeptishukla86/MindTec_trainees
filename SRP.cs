using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srp
{
    public interface Itransac
    {
        void credit(int x);
        void debit(int y);
    }
    public interface IInterest
    {
        void cal();
    }

    class Transac : Itransac
    {

        public int balance;
        public Transac()
        {
            balance = 1000;
            Console.WriteLine("Your Initial Balance is : " + balance);
        }
        public void credit(int s)
        {
            balance += s;
            Console.WriteLine("Your Current Balance : " + balance);
        }
        public void debit(int s)
        {
            if (s < balance)
            {
                balance -= s;
                Console.WriteLine("Your Current Balance i: " + balance);

            }
            else
            {
                Console.WriteLine("!!!........Your Balance is low, credit first......!!!");

            }

        }
    }
    class Calculate : IInterest
    {

        
        public void cal()
        {
            int t,balance;

            Console.WriteLine("Enter the number of year: ");
            t = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the balance ");
            balance  = Convert.ToInt32(Console.ReadLine());

            double interest = (balance * t * 6) / 100;

            Console.WriteLine("Your Interest : " + interest);
            Console.WriteLine("Your total balance would be :" + (balance + interest));

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Transac t = new Transac();
            t.credit(700);
            t.credit(590);
            t.debit(3000);
            t.debit(69500);
            Calculate c = new Calculate();
            c.cal();

        }
    }
}

