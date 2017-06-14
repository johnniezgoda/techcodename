using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            students.Add("Ani");
            students.Add("Shannon");
            students.Add("Colin");
            students.Add("Anthony");
            students.Add("Geoffrey");

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
