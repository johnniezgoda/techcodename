using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorConditions
{
    class Program
    {
        static string askQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            double Time;
            Time = Convert.ToDouble(askQuestion("What time is it? Please use military time"));
            if (Time >= 12 && Time <= 16)
            {
                double Rain;
                Rain = Convert.ToDouble(askQuestion("What is the chance of rain in percents? Please write the number without the percent sign."));
                if (Rain <= 30)
                {
                    double Air;
                    Air = Convert.ToDouble(askQuestion("What is the temperature of the air in Farenheight?"));
                    if (Air >= 80)
                    {
                        double Water;
                        Water = Convert.ToDouble(askQuestion("What is the water temperature in Farenheight?"));
                        if (Water >= 70)
                        {
                            Console.WriteLine("Go swimming and have fun, or you can also play soccer!!!");
                        }

                    }
                }
                else if (Rain <= 50 && Rain >= 30)
                {
                    Console.WriteLine("You can play Soccer now.");
                }
            }
            if (Time >= 10 && Time <= 18)
            {
                double Air;
                Air = Convert.ToDouble(askQuestion("What is the temperture outside in Farenheight?"));
                if (Air >= 60)
                {
                    double Rain;
                    Rain = Convert.ToDouble(askQuestion("What is the probability of rain right now. Please type just the number and not the percent sign."));
                    if (Rain <= 50)
                    {
                        Console.WriteLine("YOu can play soccer! Have Fun!!!!!");
                    }
                }
            }
               

        }
    }
}
