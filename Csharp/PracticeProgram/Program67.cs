using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherExOfSingleLevelInheritance
{
    class Person
    {
        public string name;
        public string address;
    }
    class Student : Person 
    {
        public int rollno;
        public int marks;
    }
    internal class TestInheritance
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.rollno = 11;
            S.name = "Saanvi";
            S.address = "Pratap nagar";
            S.marks = 200;

            Console.WriteLine("rollno = " + S.rollno);
            Console.WriteLine("name = " + S.name);
            Console.WriteLine("address = " + S.address);
            Console.WriteLine("marks = " + S.marks);
            Console.ReadLine();

        }
    }
}
