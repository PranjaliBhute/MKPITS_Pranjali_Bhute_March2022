using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrgmOfGetdataAndShowdata
{
    class Employee
    {
        public int empno;
        public string empname;
        public float salary;
      
        public void getdata()
        {
            Console.WriteLine("Enter employee no : ");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name : ");
            empname = Console.ReadLine();
            Console.WriteLine("Enter employee salary : ");
            salary = Convert.ToSingle(Console.ReadLine());

        }
        public void displaydata()
        {
            Console.WriteLine("empno = " + empno);
            Console.WriteLine("empname = " + empname);
            Console.WriteLine("salary  = " + salary);
        }

    }
    internal class Program
    {
         static void Main(string[] args)
        {
           Employee emp = new Employee();

            emp.getdata();
            emp.displaydata();
            Console.ReadLine();
        }
    }
}
