using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        public int empno;
        public string empname;
        public float salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.empno = 21;
            emp.empname = "Pranjali";
            emp.salary = 20000.0f;
            Console.WriteLine("Employee number : " + emp.empno);
            Console.WriteLine("Employee name : " + emp.empname);
            Console.WriteLine("Employee salary : " + emp.salary);
            Console.ReadLine();

        }
    }
}
