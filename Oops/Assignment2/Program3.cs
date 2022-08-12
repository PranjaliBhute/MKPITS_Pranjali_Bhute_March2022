using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_ParameterisedConstWith4Parameters
{
    class Employee
    {
        int empno;
        string empname, designation;
        int salary;

        public Employee()
        {
            empno = 1;
            empname = "Pranjali";
            designation = "Manager";
            salary = 25000;
        }
        public Employee(int empno, string empname, string designation, int salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.designation = designation;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("Employee No. = " + empno);
            Console.WriteLine("Employee Name = " + empname);
            Console.WriteLine("Employee Designation = " + designation);
            Console.WriteLine("Employee Salary = " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.display();
            Console.WriteLine("---------Employee Details-----------");
            Console.WriteLine("\n");
            Employee emp1 = new Employee(1, "Pranjali", "Manager", 25000);
            emp1.display();
            Console.WriteLine("----------Employee1 Details--------------");
            Console.WriteLine("\n");
            Console.WriteLine("Enter employee no. = ");
            int empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name = ");
            string empname = Console.ReadLine();
            Console.WriteLine("Enter designation = ");
            string designation = Console.ReadLine();
            Console.WriteLine("Enter salary = ");
            int salary = Convert.ToInt32(Console.ReadLine());
            Employee emp2 = new Employee(empno, empname, designation,salary);
            emp2.display();
            Console.WriteLine("------------Employee2 Details------------");
            Console.ReadLine();

        }
    }
}
