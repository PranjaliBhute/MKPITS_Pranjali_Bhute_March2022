using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_Encapsulation
{
    class Employee
    { 
         public string empname { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.empname = "ravi";
            Console.WriteLine("empname " + emp.empname);
            Console.ReadLine();
        }
    }
}
