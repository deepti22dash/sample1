using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasslibraryFact;

namespace ConsoleAppFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter numbers to calculate");
            int num = Convert.ToInt32(Console.ReadLine());

            Factorial f = new Factorial();
            int res = f.Fact(num);

            Console.WriteLine(" Factorial is " + res);
            Console.ReadKey();
        }
    }
}
