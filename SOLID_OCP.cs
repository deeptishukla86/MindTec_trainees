using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocp
{
    public interface Itransac
    {
        void credit(int x);
        void debit(int y);
    }
    public interface IInterest
    {
        void cal(int bal);
    }

    public class Regular_Account
    {
        public void cal(int balance)
        {
            int t, r = 5;
            Console.WriteLine("Enter the number of year: ");
            t = Convert.ToInt32(Console.ReadLine());

            double interest = (balance * t * r) / 100;

            Console.WriteLine("Your Interest : " + interest);
            Console.WriteLine("Your total balance would be :" + (balance + interest));
        }
    }

    public class Salary_Account
    {
        public void cal(int balance)
        {
            int t, r = 7;
            Console.WriteLine("Enter the number of year: ");
            t = Convert.ToInt32(Console.ReadLine());

            double interest = (balance * t * r) / 100;

            Console.WriteLine("Your Interest : " + interest);
            Console.WriteLine("Your total balance would be :" + (balance + interest));
        }
    }

    public class Child_Saving_Account
    {
        public void cal(int balance)
        {
            int t, r = 9;
            Console.WriteLine("Enter the number of year: ");
            t = Convert.ToInt32(Console.ReadLine());

            double interest = (balance * t * r) / 100;

            Console.WriteLine("Your Interest is: " + interest);
            Console.WriteLine("Your total balance would be :" + (balance + interest));
        }
    }

    class Transac : Itransac
    {

        public int balance;
        public Transac()
        {
            balance = 5000;
            Console.WriteLine(" Initial Balance is : " + balance);
        }
        public void credit(int s)
        {
            balance += s;
            Console.WriteLine(" Current Balance is " + balance);
        }
        public void debit(int s)
        {
            if (s < balance)
            {
                balance -= s;
                Console.WriteLine(" Current Balance is " + balance);

            }
            else
            {
                Console.WriteLine(" !!!!............Balance is low, credit first....!!!!");

            }

        }
    }
    class Calculate : IInterest
    {
        public void cal(int balance)
        {
            int t, r = 6;
            Console.WriteLine("Enter the number of year: ");
            t = Convert.ToInt32(Console.ReadLine());
            double interest = (balance * t * r) / 100;
            Console.WriteLine("Your Interest is: " + interest);
            Console.WriteLine("Your total balance would be :" + (balance + interest));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Transac t = new Transac();
            Console.WriteLine("**************** TYPE OF ACCOUNT************ ");
            Console.WriteLine("\n 1 for Regular\n 2 for salary\n 3 for Child Saving");

            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Regular_Account ra = new Regular_Account();
                    t.credit(100);
                    t.credit(100);
                    t.debit(1000);
                    ra.cal(t.balance);
                    break;
                case 2:
                    Salary_Account sa = new Salary_Account();
                    t.credit(500);
                    t.credit(500);
                    t.debit(5000);
                    sa.cal(t.balance);
                    break;
                case 3:
                    Child_Saving_Account csa = new Child_Saving_Account();
                    t.credit(600);
                    t.credit(600);
                    t.debit(6000);
                    csa.cal(t.balance);
                    break;
                default:
                    break;
            }
            
        }
    }
}
