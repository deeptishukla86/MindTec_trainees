using System;

namespace OpenColse
{
   
    public interface ISavingAccount
    {  
   //Other method and property and code  
      public void CalculateInterest();
    }
    public class RegularSavingAccount : ISavingAccount
    {
        //Other method and property and code related to Regular Saving account  
        public void CalculateInterest()
        {
            //Calculate interest for regular saving account based on rules and   
            // regulation of bank  
            Console.WriteLine("enter amount for regular saving account");
            int balance = Convert.ToInt32(Console.ReadLine());
            double interest = balance * 0.4;
            int amount = 0;
            if (balance < 1000) interest -= balance * 0.2;
            if (balance < 50000) interest += balance * 0.4;
            Console.WriteLine("interst is :" + interest);

        }
    }


        public class SalarySavingAccount : ISavingAccount
        {
            //Other method and property and code related to Salary Saving account`  
            public void CalculateInterest()
            {
            //Calculate interest for saving account based on rules and regulation of   
            //bank  
            Console.WriteLine("enter amount for salary saving account");

            int balance = Convert.ToInt32(Console.ReadLine());

                double Interest = balance * 0.5;
            Console.WriteLine("interest is : " + Interest);
            }
        }
        public class childsavingaccount : ISavingAccount
        {
            public void CalculateInterest()
            {
            Console.WriteLine("enter amount for child saving account");

            int balance = Convert.ToInt32(Console.ReadLine());
                double interest = balance * 0.2;
            Console.WriteLine("interest is : " + interest);

        }
    }


            class program
            {
                public static void Main(String[] args)
                {
                    ISavingAccount obj = new RegularSavingAccount();
                    obj.CalculateInterest();

                    ISavingAccount obj1 = new SalarySavingAccount();
                    obj1.CalculateInterest();

                    ISavingAccount obj2 = new childsavingaccount();
                    obj2.CalculateInterest();


                }
            }

        }
    
