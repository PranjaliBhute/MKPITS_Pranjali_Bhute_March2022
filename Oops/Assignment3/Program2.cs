using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfInheritanceMethod
{
    class Person
    {
        string name, address;
        public void getPersonData(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("name = " + name);
            Console.WriteLine("address = " + address);
        }
        public class Employee : Person
        {
            int empno, salary;
            public void getEmployeeData(int empno, int salary)
            {
                this.empno = empno;
                this.salary = salary;
            }
            public void displayEmployeeData()
            {
                Console.WriteLine("empno = " + empno);
                Console.WriteLine("salary = " + salary);
            }

        }
        internal class Testinheritance
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                emp.getPersonData("Saanvi", "Pratap Nagar");
                emp.displayPersonData();
                emp.getEmployeeData(11, 30000);
                emp.displayEmployeeData();
                Console.ReadLine();

            }
        }
    }
}    

