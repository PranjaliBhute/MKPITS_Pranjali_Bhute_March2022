using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfStudentDetails
{
    class Student
    {
        int rollno;
        string name, course;
        int fees;

        public void getdata()
        {
            rollno = 1;
            name = "Saanvi";
            course = ".Net";
            fees = 7000;
        }
        public void getdata(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
        public void getdata(int rollno, string name, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }
        public void getdata(int rollno, string name, string course, int fees)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
            this.fees = fees;
        }
        public void display()
        {
            Console.WriteLine("Student rollno = " + rollno);
            Console.WriteLine("Student name = " + name);
            Console.WriteLine("Student course = " + course);
            Console.WriteLine("Student fees = " + fees);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.getdata();
            S.display();
            Console.WriteLine("----------Student Details------------");
            Console.WriteLine("\n");
            Student S1 = new Student();
            S1.getdata(1, "Saanvi");
            S1.display();
            Console.WriteLine("----------Student1 Details-------------");
            Console.WriteLine("\n");
            Student S2 = new Student();
            S2.getdata(1, "Pranjali", ".Net");
            S2.display();
            Console.WriteLine("----------Student2 Details------------");
            Console.WriteLine("\n");
            Student S3 = new Student();
            S3.getdata(1, "Pranjali", ".Net", 2000);
            S3.display();
            Console.WriteLine("---------Student3 Details-------------");
            Console.WriteLine("\n");
            Console.ReadLine();

        }
    }
}
