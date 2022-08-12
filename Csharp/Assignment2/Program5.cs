using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetailsUsingIfelse
{
    internal class EmployeeDetailsProgram
    {
        static void Main(string[] args)
        {
            string empname, designation;
            int bonus = 0, empno;
            Console.WriteLine("Enter Employee number : ");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee name : ");
            empname = Console.ReadLine();
            Console.WriteLine("Enter designation : ");
            designation = Console.ReadLine();
            if (designation == "manager")
            {
                bonus = 10000;
            }
            else if (designation == "clerk")
            {
                bonus = 5000;
            }
            else if (designation == "peon")
            {
                bonus = 2000;
            }
            else
            {
                Console.WriteLine("Invalid designation");
            }
            Console.WriteLine("Bonus = " + bonus);
            Console.ReadLine();
        }
    }
}
