using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfEmployeeDisplayhra_da_ta_sal
{
    class Employee
    {
        public int empno;
        public float basicsal, total, HRA, DA, TA;
        public string empname;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Employee emp = new Employee();

                Console.WriteLine("Enter the employee number = ");
                emp.empno = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter the basic salary = ");
                emp.basicsal = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter the employee name = ");
                emp.empname = Console.ReadLine();

                emp.HRA = emp.basicsal * 0.32f;
                emp.DA = emp.basicsal * 0.45f;
                emp.TA = emp.basicsal * 0.43f;

                emp.total = emp.basicsal + emp.HRA + emp.DA + emp.TA;
                Console.WriteLine("name = " + emp.empname);
                Console.WriteLine("id no = " + emp.empno);
                Console.WriteLine("salary = " + emp.basicsal);
                Console.WriteLine("HRA = " + emp.HRA);
                Console.WriteLine("DA = " + emp.DA);
                Console.WriteLine("TA = " + emp.TA);

                Console.WriteLine("Total salary of employee = " + emp.total);
                Console.ReadLine();


        }
    }
}
