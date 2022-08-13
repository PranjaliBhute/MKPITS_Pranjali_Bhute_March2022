using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfSingleLevelInheritance
{
    class Employee
    {
        protected int salary;
    }
    class Programmer : Employee 
    {
        int bonus;

        public void getdata(int salary, int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }
        public void displaydata()
        {
            Console.WriteLine("salary = " + salary);
            Console.WriteLine("bonus = " + bonus);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer P = new Programmer();
            P.getdata(25000, 20000);
            P.displaydata();
            Console.ReadLine();
        }
    }
}
