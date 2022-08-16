using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessesTheFieldOfBaseClass
{
    class Person
    {
        public string name = "Mkpits";
    }
    class Student : Person
    {
        public string name = "Roshan";
        public void display()
        {
            Console.WriteLine("name = " + name); 
            Console.WriteLine("base class field name = " + base.name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.display();
            Console.ReadLine();
        }
    }
}
