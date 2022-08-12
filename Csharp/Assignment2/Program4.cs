using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetailsProgramUsingSwitch
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
            switch (designation)
            {
                case "manager":
                    bonus = 10000;
                    break;
                case "clerk":
                    bonus = 5000;
                    break;
                case "peon":
                    bonus = 2000;
                    break;
                default:
                    Console.WriteLine("Invalid designation");
                    break;
            }

            Console.WriteLine("empno = {0} , empname = {1} , bonus = {2}", empno , empname , bonus);
            Console.ReadLine();


        }
    }
}
