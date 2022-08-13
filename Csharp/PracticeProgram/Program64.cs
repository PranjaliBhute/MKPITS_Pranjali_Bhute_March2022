using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfStudentUsingVariable
{
    class Student
    {
        int rollno;
        string name;

        public Student()
        {
            rollno= 11;
            name = "Saanvi";
        }
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
        public void displaydata()
        {
            Console.WriteLine("rollno = " + rollno);
            Console.WriteLine("name = " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.displaydata();
            Student S1 = new Student(11, "Saanvi");
            S1.displaydata();
            Console.ReadLine();
        }
    }
}
