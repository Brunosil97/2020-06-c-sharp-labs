using System;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace lab_17_selection
{
    class Program
    {

    }

    public class Selection
    {
        static void Main(string[] args)
        {
            var grade = PassFail(41);
            Console.WriteLine(grade);

            var mark = MarkGrade(76);
            Console.WriteLine(mark);

            var level = AmberAlertLevel(3);
            Console.WriteLine(level);

            int x = 5;
            int y = 10;

            var ifelse = x > y ? "X is greater" : "X is less";
            Console.WriteLine(ifelse);

            var ternaryResult = PassFailTernary(40);
            Console.WriteLine(ternaryResult);
        }

        public static string PassFail(int mark)
        {
            var grade = "Fail";
            if (mark >= 40)
            {
                grade = "Pass";
            }
            return grade;
        }

        public static string MarkGrade(int mark)
        {
            var grade = "Fail";
            if (mark >= 75 && mark <=100)
            {
                grade = "Pass with Distinction";
            }
            else if (mark >= 60 && mark < 75)
            {
                grade = "Pass with Merit";
            }
            else if (mark >= 40 && mark < 60)
            {
                grade = "Pass";
            }
            return grade;
        }

        public static string AmberAlertLevel(int level)
        {
           string priority = "Code ";

           switch(level)
            {
                case 3:
                    priority = priority + "Red";
                    break;
                case 2:
                    priority = priority + "Amber";
                    break;
                case 1:
                    priority = priority + "Green";
                    break;
                default:
                    priority = "error";
                    break;
            }
            return priority;
        }

        public static string PassFailTernary(int mark)
        {
            return mark >= 40 ? "Pass" : "Fail";
        }
    }
}
