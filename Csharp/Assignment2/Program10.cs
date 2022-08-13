using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrgmOfDisplayEmpHraDaTotalSal
{
    internal class DisplayTotalSalary
    {
        static void Main(string[] args)
        {
            int empno, basicsal;
            Console.WriteLine("Enter Employee number : ");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter basic salary : ");
            basicsal = Convert.ToInt32(Console.ReadLine());
            float hra = 0;
            float da = 0;
            switch (basicsal)
            {
                case 25000:
                    hra = basicsal * 0.32f;
                    da = basicsal * 0.45f;
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
                
            }
            float total = basicsal + hra + da;
            Console.WriteLine("empno " + empno);
            Console.WriteLine("hra " + hra);
            Console.WriteLine("da " + da);
            Console.WriteLine("total salary " + total);
            Console.ReadLine();
         }
    }
}
