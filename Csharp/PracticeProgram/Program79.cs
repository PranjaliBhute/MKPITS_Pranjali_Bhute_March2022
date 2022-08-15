using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_Protected
{
    class Person
    {
        string name;
        protected void getpersondata(string name)
        {
            this.name = name;
            Console.WriteLine("name = " + name);
        }
            
    }
    class Employee : Person
    {
        int empno;
        internal void getemployeedata(int empno, string name)
        {
            getpersondata(name);
            this.empno = empno;
            Console.WriteLine("empno = " + empno);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getemployeedata(11, "Saanvi");
            Console.ReadLine();
        }
    }
}
