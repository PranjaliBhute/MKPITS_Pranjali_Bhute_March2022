using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_AcptValFrmUser
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
            Console.WriteLine("Enter employee number : ");
            emp.empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name : ");
            emp.empname = Console.ReadLine();
            Console.WriteLine("Enter employee salary : ");
            emp.salary = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("empno = " + emp.empno);
            Console.WriteLine("empname = " + emp.empname);
            Console.WriteLine("salary = " + emp.salary);
            Console.ReadLine();

        }
    }
}
