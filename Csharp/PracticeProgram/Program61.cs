using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgmOfStudentUsingInternalSpecifier
{
    class Student
    {
        internal int rollno;
        internal string name;

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
            S.rollno = 11;
            S.name = "Saanvi";
            S.displaydata();
            Console.ReadLine();
        }
    }
}
