using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoPractice
{
    class Program
    {
        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            double temperature;
            temperature = Convert.ToDouble (AskQuestion("What is the temperature in degrees Farenheight."));
            }
        }
    }
}
