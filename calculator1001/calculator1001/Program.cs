using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator100;

namespace calculator1001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Functions.Addition(4, 6));
            Console.WriteLine(Functions.Subtraction(8, 5));
            Console.WriteLine(Functions.Multiplication(3, 8));
            Console.WriteLine(Functions.Division(10, 2));
            Console.ReadKey();
        }
    }
}
