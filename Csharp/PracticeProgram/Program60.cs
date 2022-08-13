using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfInheritance
{
    class Person
    {
        protected string name;
    }
    class Student : Person 
    {
        public void getdata()
        {
            name = "Saanvi";
            Console.WriteLine("name = " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.getdata();
            Console.ReadLine();
        }
    }
}
