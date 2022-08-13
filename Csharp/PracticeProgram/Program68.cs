using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfInheritanceSpecifier
{
    class Person
    {
        public string name;
    }
    class Student : Person 
    {
        public int rollno;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.rollno = 11;
            S.name = "Saanvi";
            Console.WriteLine("rollno = " + S.rollno);
            Console.WriteLine("name = " + S.name);
            Console.ReadLine();
        }
    }
}
