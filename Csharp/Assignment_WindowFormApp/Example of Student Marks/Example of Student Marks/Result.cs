using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_Student_Marks
{
    class Result
    {
        public int phy, chem, math, total;
        public float per;
        public string grade;
        public  string total(int phy, int chem, int math)
        {
            total = phy + chem + math;
            return "Total amount is = " + total.ToString();
        }
        public string percentage()
        {
            per = total / 300.0f * 100.0f;
            return "Percentage is = " + per.ToString();
        }
        public string gradecal()
        {
            if (per >= 75)
                grade = "Distinction";
            else if (per < 75 && per >= 60)
                grade = "First class";
            else if (per < 60 && per >= 50)
                grade = "Second class";
            else
                grade = "Fail";
            return "Grade is " + grade.ToString();
        }
    }
}
