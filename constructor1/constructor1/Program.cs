using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor1
{
    class BankAccount
    {
        public int actno;
        public BankAccount()
        {
            actno = 22;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();
            Console.WriteLine("Account no " + ba.actno);
            Console.ReadKey(); 
        }
    }
}
