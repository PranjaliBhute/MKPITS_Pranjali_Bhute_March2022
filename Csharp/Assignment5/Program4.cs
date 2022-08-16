using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingBaseClassConstructorInternally
{
    class Person
    {
        string name = "Mkpits";
        public Person()
        {
            Console.WriteLine("Person class constructor called");
        }
        public void display()
        {
            Console.WriteLine("Base class field name = " + name);
        }
    }
    class Student : Person 
    {
        string name = "Roshan";
        public Student()
        {
            Console.WriteLine("Student class constructor called");
        }
        public void display()
        {
            base.display();
            Console.WriteLine("Child class field name = " + name);
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
