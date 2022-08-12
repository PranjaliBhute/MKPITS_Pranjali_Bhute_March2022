using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfEmployeeDetails_Inheritance_
{
    class Person
    {
        public string name;
        public string address;
    }
    class Employee : Person 
    {
        public int empno;
        public  float salary;
        public string designation;

    }
    internal class TestInheritance
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.empno = 1;
            emp.name = "Saanvi";
            emp.address = "Pratap nagar";
            emp.designation = "Manager";
            emp.salary = 20000;

            Console.WriteLine("empno = " + emp.empno);
            Console.WriteLine("name = " + emp.name);
            Console.WriteLine("address = " + emp.address);
            Console.WriteLine("designation = " + emp.designation);
            Console.WriteLine("salary = " + emp.salary);
            Console.ReadLine();
        }
    }
}
