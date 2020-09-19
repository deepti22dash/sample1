using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useofexpression
{
    public class Location
    {
        private string locname;
        public Location(string name) => Name = name;
        public string Name
        {
            get => locname;
            set => locname = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Location l = new Location(" Anant");
            Console.ReadKey();
        }
    }
}
