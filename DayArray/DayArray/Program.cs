using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentInClass = new string[5];
            studentInClass[0] = "John";
            studentInClass[1] = "Josh";
            studentInClass[2] = "Evan";
            studentInClass[3] = "Dylan";
            studentInClass[4] = "Logan";

            int i = 0;
            while(i < studentInClass.Length)
            {
                Console.WriteLine(studentInClass[i]);
                i++;
            }
        }
    }
}
