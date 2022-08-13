using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Internal_Access_Modifier
{
    public class Person
    {
        string name;
        string address;
        protected internal void getPersonData(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        protected internal void displayPersonData()
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
           
            this.rno = rno;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            
            Console.WriteLine("rno : " + rno);
            Console.WriteLine("marks : " + marks);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Student p1 = new Student();
                p1.getPersonData("Saanvi", "Pratap nagar");
                p1.getStudentData(111, 999);
                p1.displayStudentData();
                p1.displayPersonData();
                Console.ReadLine();


        }
    }
}
