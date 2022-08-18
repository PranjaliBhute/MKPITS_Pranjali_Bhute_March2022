using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Access_Specifier
{
    class Student
    { 
      public string Id { get; set; }
      public string Name { get; set; }
      public string Email { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.Id = "101";
            S.Name = "Pranjali";
            S.Email = "bhutepranjali@gmail.com";
            Console.WriteLine("Id = " + S.Id);
            Console.WriteLine("Name = " + S.Name);
            Console.WriteLine("Email = " + S.Email);
            Console.ReadLine();
        }
    }
}
