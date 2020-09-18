using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelligentoverriding
{
    class Figure
    {
        public virtual void draw()
        {
            Console.WriteLine("It is the coding for figure class.");
        }
    }
    class Rectangle : Figure
    {
        public override void draw()
        {
            Console.WriteLine(" Itis the coding for rectangle class.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure r = new Rectangle();
            r.draw();
            Console.ReadKey();
        }
    }
}
