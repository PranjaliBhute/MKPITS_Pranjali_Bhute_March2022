using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt3SubMarks
{
    internal class SubjectMarks
    {
        static void Main(string[] args)
        {
            int s1, s2, s3,total;
            float per;
            string grade = " ";
            Console.WriteLine("Enter first sub mark : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second sub mark : ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third sub mark : ");
            s3 = Convert.ToInt32(Console.ReadLine());
            total = s1 + s2 + s3;
            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("Total = " + total);
            Console.WriteLine("Percentage = " + per);
            if (per >= 75)
            {
                grade = "distinction";
            }
            else if (per >= 60 && per < 75)
            {
                grade = "first";
            }
            else
            {
                grade = "fail";
            }
            Console.WriteLine("Grade = " + grade);
            Console.ReadLine();

        }
    }
}
