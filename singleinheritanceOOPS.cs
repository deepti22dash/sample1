using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinlgeInheirtance
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public string EmployeeDesignation { get;  set;}
        public double  EmployeeSalary { get; set; }
        public void GetEmployeeDetails (int employeeNumber, string employeeName , string employeeAddress, string employeeDesignation, double employeeSalary)
        {
            EmployeeNumber = employeeNumber;
            Name = employeeName;
            Address = employeeAddress;
            EmployeeDesignation = employeeDesignation;
            EmployeeSalary = employeeSalary;
        }
        public void showEmployeeDetails()
        {
            Console.WriteLine("Employeedetails are :");
            Console.WriteLine("empno:" + EmployeeNumber);
            Console.WriteLine("empname :" + Name);
            Console.WriteLine("empaddress:" + Address);
            Console.WriteLine("empDestination:" + EmployeeDesignation );
            Console.WriteLine("empSalary" + EmployeeSalary);
        }  
    }
    class Program 
    {
        static void Main(string[] args)
        {
            int employeeNumber;
            string employeeName, employeeAddress, employeeDesignation;
            double salary;
            Employee e1 = new Employee();
            Console.WriteLine(" Enter emp no:");
            employeeNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter emp name:");
            employeeName = Console.ReadLine();
            Console.WriteLine(" Enter emp address:");
            employeeAddress = Console.ReadLine(); ;
            Console.WriteLine(" Enter emp designation :");
            employeeDesignation = Console.ReadLine();
            Console.WriteLine(" Enter emp salary :");
            salary = Convert.ToInt32(Console.ReadLine());
            e1.GetEmployeeDetails(employeeNumber, employeeName, employeeAddress, employeeDesignation, salary);
            e1.showEmployeeDetails();
            Console.ReadKey();
        }
    }
}
