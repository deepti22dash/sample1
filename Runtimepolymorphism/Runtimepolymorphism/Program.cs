using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtimepolymorphism
{
    class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public Account()
        {
            Balance = 1000;
        }
        public virtual string Deposite( double amount)
        {
            return " Hello from Account class deposite method ";
        }
        public string showBalance()
        {
            return " Balance amount of Account number :" + "AccountNumber  is: " + Balance;
        }
    }
    class Saving : Account
    {
         public void Interest { get; set; }
        public void override String Deposite(double amount)
        {
            Interest = 500;
            Balance = Balance + amount + Interest;
            return "Amount deposited successfully with interest. Balance is :"+Balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int actno; 
            double amt;
            Console.WriteLine(" Enter account number please");
            actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the amount :");
            amt= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the acccount type :");
            string accounttype = Console.ReadLine();
            string result = null;
            string result1 = null;
            Account act = null;
            if (accounttype=="Saving")
            {
                act = new Saving();
            }
             else if (accounttype=="current")
            {
                act = new current();
            }
            act.AccountNumber = actno;
            result = act.Deposite(amt);
            result1 = act.showBalance();
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.ReadKey ();
        }
    }
}
