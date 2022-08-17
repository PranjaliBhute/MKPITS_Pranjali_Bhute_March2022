using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_of_person
{
    abstract class Person
    {
        public abstract void display();
        public void showdata()
        {
            Console.WriteLine("Hello from showdata");
        }
    }
    class Student : Person
    {
        public override void display()
        {
            Console.WriteLine("Hello from display method");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.display();
            s.showdata();
            Console.ReadLine();

        }
    }
}
