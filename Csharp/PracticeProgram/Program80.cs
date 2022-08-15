using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_multilevel_inheritance
{
    public class Person
    {
        string name;
        string address;
        public void getpersondata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersondata()
        {
            Console.WriteLine("name = " + name);
            Console.WriteLine("address = " + address);
        }
    }
    public class Employee : Person
    {
        int salary;
        string designation;

        public void getemployeedata(int salary, string designation)
        {
            this.salary = salary;
            this.designation = designation;
        }
        public void displayemployeedata()
        {
            Console.WriteLine("salary = " + salary);
            Console.WriteLine("designation = " + designation);
        }
    }
    public class Parttimeemployee : Employee
    {
        int no_of_hours;

        public void getparttimeemployeedata(int no_of_hours)
        {
            this.no_of_hours = no_of_hours;
        }
        public void displayparttimeemployeedata()
        {
            Console.WriteLine("no_of_hours = " + no_of_hours);
        }
    }
    internal class TestInheritance
    {
        static void Main(string[] args)
        {
            Parttimeemployee P = new Parttimeemployee();
            P.getpersondata("Saanvi", "Nagpur");
            P.displaypersondata();
            P.getemployeedata(11, "Manager");
            P.displayemployeedata();
            P.getparttimeemployeedata(2);
            P.displayparttimeemployeedata();
            Console.ReadLine();

        }
    }
}
