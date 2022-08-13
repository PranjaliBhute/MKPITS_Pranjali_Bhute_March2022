using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfStudentUsingMethods
{
    class Student
    {
        int rollno;
        string name;

        public void getstudentdata()
        {
            rollno = 11;
            name = "Saanvi";
        }
        public void getstudentdata(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
        public void getstudentdata(string name, int rollno)
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
            S.getstudentdata();
            S.displaydata();
            S.getstudentdata(11, "Saanvi");
            S.displaydata();
            S.getstudentdata("Saanvi", 11);
            S.displaydata();
            Console.ReadLine();
        }
    }
}
