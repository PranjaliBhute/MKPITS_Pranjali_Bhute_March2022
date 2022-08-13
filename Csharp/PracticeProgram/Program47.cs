using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetailsUsingMethod
{
    class Employee
    {
         int empno;
         string empname;
         float salary;

        public  void getdata(int a, string b, float c)
        {
            empno = a;
            empname = b;
            salary = c;
        }
        public void displaydata()
        {
            Console.WriteLine("empno = " + empno);
            Console.WriteLine("empname = " + empname);
            Console.WriteLine("salary = " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter employee number : ");
            int eno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name : ");
            string en = Console.ReadLine();
            Console.WriteLine("Enter salary : ");
            float sal = Convert.ToSingle(Console.ReadLine());

            emp.getdata(eno,en,sal);
            emp.displaydata();
            Console.ReadLine();
        }
    }
}
