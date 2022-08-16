using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingBaseClassMethod
{
    class Person
    {
        string name = "Mkpits";
        public void display()
        {
            Console.WriteLine("Base class fiels name = " + name);
        }
    }
    class Student : Person 
    {
        string name = "Roshan";
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
