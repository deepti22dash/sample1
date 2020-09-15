using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevelinheritance
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
    class Employee: Person
    {
        public int EmployeeNumber { get; set; }
        public string Designation { get; set; }
        public void getEmployeeData(string name , string address, int employeenumber, string designation)
        {
            Name = name;
            Address = address;
            EmployeeNumber = employeenumber;
            Designation = designation;
        }
        public void showEmployeeData()
        {
            Console.WriteLine(" Name:" + Name);
            Console.WriteLine(" Address:" + Address);
            Console.WriteLine(" Emp number:" + EmployeeNumber );
            Console.WriteLine(" Emp designation:" + Designation );
        }
        class partTimeEmployee:Employee
        {
            public int NoOfHours { get; set; }
            public void getEmployeeData(int nuOfHours, string Name, string Address, int employeeNumber, string designation )
            {
                NoOfHours = nuOfHours;
                Name = Name;
                Address = Address;
                EmployeeNumber = employeeNumber;
                Designation = designation;
            }
            public void showEmployeeData()
            {
                Console.WriteLine(" no of hours " + NoOfHours);
                Console.WriteLine(" NAME " + Name );
                Console.WriteLine(" Address " + Address );
                Console.WriteLine(" Employee number " + EmployeeNumber );
                Console.WriteLine(" Designation is " + Designation );
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.getEmployeeData(" Gourav", "Bargarh", 07, "Manager");
            e.showEmployeeData();
            partTimeEmployee pt = new partTimeEmployee();
            
            pt.getEmployeeData("VIBHA", " Jharsuguda", 10, " HR MANAGER");
            pt.showEmployeeData();
        }
    }
}
