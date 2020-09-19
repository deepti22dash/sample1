using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramerisedconst
{
    public class Person
    {
        private string first;
        private string last;
        public Person(string firstname, string lastname)
        {
            first = firstname;
            last = lastname;
        }
        public void show()
        {
            Console.WriteLine("FIRSTNAME " +first);
            Console.WriteLine(" LASTNAME " +last);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Vibha" , "Dash");
            p.show();
            Console.ReadKey(); 
                
        }
    }
}
;