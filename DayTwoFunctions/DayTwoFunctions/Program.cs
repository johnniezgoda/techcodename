using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoFunctions
{
    
    class Program
    {
        
        static string createNamesString(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }

        static void giveStudentGrade(string firstName, string lastName, int score)
        {
            string grade = "pass";
            if (score > 79 && score < 90)
            {
                grade = "pass";
            }
            else if (score > 69 && score < 80)
            {
                grade = "pass";
            }
            else if (score > 59 && score < 70)
            {
                grade = "fail";
            }
            else if (score > 0 && score < 60)
            {
                grade = "fail";
            }
            Console.WriteLine(createNamesString(firstName, lastName)+ ": " + grade);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(createNamesString("", ""));
            giveStudentGrade("Tim", "Burr", 70);
            giveStudentGrade("Al", "Dente", 2);
            giveStudentGrade("Sue", "Flay", 7);
        }
    }
}
