using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfInheritingMethods
{
    class Person
    {
        string name;
        string address;

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
        public class Student : Person
        {
            int rollno;
            int marks;

            public void getStudentData(int rollno, int marks)
            {
                this.rollno = rollno;
                this.marks = marks;
            }
            public void displayStudentData()
            {
                Console.WriteLine("rollno = " + rollno);
                Console.WriteLine("marks = " + marks);
            }

        }
        internal class TestInheritance
        {
            static void Main(string[] args)
            {
                Student S = new Student();
                S.getPersonData("Saanvi", "Pratap nagar");
                S.displayPersonData();
                S.getStudentData(11, 150);
                S.displayStudentData();
                Console.ReadLine();
            }
        }
    }
}    

