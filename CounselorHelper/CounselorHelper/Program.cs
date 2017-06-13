using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            double WaterTemp;
            double AirTemp;
            int ProbORain;
            int TimeDay;

            Console.Write("Please Enter water temp");
            WaterTemp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter Air Temp");
            AirTemp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the rain probability");
            ProbORain = Convert.ToInt32(Console.ReadLine());
            Console.Write("PLease enter the time of day in a 24 hour format");
            TimeDay = Convert.ToInt32(Console.ReadLine());

            int NumActivities = 0;

            if (TimeDay >= 12 && TimeDay <= 16 && WaterTemp > 70 && AirTemp > 80 && ProbORain < 30)
            {
                Console.WriteLine("Take the kids swimming!");
                NumActivities++;
            }
            if (AirTemp > 60 && ProbORain < 50 && TimeDay >= 10 && TimeDay <= 18)
            {
                Console.WriteLine("Play Soccer!");
                NumActivities++;
            }
            if (ProbORain > 60 || TimeDay > 18)
            {
                Console.WriteLine("Play board games");
                NumActivities++;
            }
            if (TimeDay > 20)
            {
                Console.WriteLine("Watch Movies");
                NumActivities++;
            }
            if (NumActivities == 0)
            {
                Console.WriteLine("No activities available.");
            }
        }
    }
}
