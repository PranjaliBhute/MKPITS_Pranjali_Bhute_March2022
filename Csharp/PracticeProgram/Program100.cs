using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_sealed_method
{
    class Person
    {
        public virtual void display()
        {
            Console.WriteLine("Hello from person");
        }
    }
    class Student : Person
    {
        public string name;
        public sealed override void display()
        {
            Console.WriteLine("Hello");
        }
    }
    class Parttime : Student
    {
        /*
        public  override void display() //error since sealed
        {
            Console.WriteLine("Hello");
        }
        */
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Parttime p = new Parttime();
            p.display();
            Console.ReadLine();

        }
    }
}
