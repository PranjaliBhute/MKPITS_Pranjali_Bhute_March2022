using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherDerivedClassEmployee
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
    public class Student : Person
    {
        int rollno;
        int marks;

        public void getstudentdata(int rollno, int marks)
        {
            this.rollno = rollno;
            this.marks = marks;
        }
        public void displaystudentdata()
        {
            Console.WriteLine("rollno = " + rollno);
            Console.WriteLine("marks = " + marks);
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
    internal class TestInheritance
    {
        static void Main(string[] args)
        {
            Student P = new Student();
            P.getpersondata("Saanvi", "Nagpur");
            P.getstudentdata(11, 150);
            P.displaypersondata();
            P.displaystudentdata();

            Employee emp = new Employee();
            emp.getpersondata("Saanvi", "Pratap nagar");
            emp.displaypersondata();
            emp.getemployeedata(20000, "Manager");
            emp.displayemployeedata();
            Console.ReadLine();
        }
    }
}
