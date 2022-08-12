using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfEmployeeDetails
{
    class Employee
    {
        int empno;
        string empname;
        string designation;
        int salary;

        public Employee()
        {
            empno = 1;
            empname = "Pranjali";
            designation = "Manager";
            salary = 30000;
        }
        public void display()
         {
                Console.WriteLine("Employee No. = " + empno);
                Console.WriteLine("Employee Name = " + empname);
                Console.WriteLine("Designation = " + designation);
                Console.WriteLine("Employee salary = " + salary);
         }
     }
     internal class Program
      {
         static void Main(string[] args)
         {
                Employee emp = new Employee();
                emp.display();
                Console.ReadLine();
         }
     }
}
