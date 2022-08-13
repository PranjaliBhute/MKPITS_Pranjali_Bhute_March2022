using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfProtectedAccessModifier
{
    public class Person
    {
        String name;
        String address;
        protected void getPersonData(String name, String address)
        {
            this.name = name;
            this.address = address;
        }
        protected void displayPersonData()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("address : " + address);

        }
    }
    public class Student : Person
    {
        int rno;
        int marks;
        public void getStudentData(int rno, int marks)
        {
            getPersonData("Saanvi", "Pratap nagar"); 
            this.rno = rno;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            displayPersonData(); 
            Console.WriteLine("rno : " + rno);
            Console.WriteLine("marks : " + marks);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student p1 = new Student();
                                      
            p1.getStudentData(111, 999);
            p1.displayStudentData();
            Console.ReadLine();
        }
    }
}
