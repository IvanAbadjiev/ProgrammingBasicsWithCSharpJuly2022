
using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elevetionForBan = int.Parse(Console.ReadLine());
            string taskName = Console.ReadLine();
            int elevetion = int.Parse(Console.ReadLine());

            double allElevvationSum = 0;
            int allTaskSum = 0;
            int elevetionSumForABan = 0;
            string lastTask = "";
            bool baned = false;

            while (taskName != "Enough")
            {
                if (elevetion <= 4)
                {
                    allElevvationSum += elevetion;
                    allTaskSum++;
                    elevetionSumForABan++;
                    if (elevetionForBan == elevetionSumForABan)
                    {
                        baned = true;
                        Console.WriteLine($"You need a break, {elevetionSumForABan} poor grades.");
                        break;
                    }

                }
                else 
                {
                    allTaskSum++;
                    allElevvationSum += elevetion;

                }
                lastTask = taskName;

                taskName = Console.ReadLine();
                if (taskName == "Enough")
                {
                    break;
                }
                elevetion = int.Parse(Console.ReadLine());
                


            }

            if (!baned)
            {
                Console.WriteLine($"Average score: {allElevvationSum / allTaskSum:f2}");
                Console.WriteLine($"Number of problems: {allTaskSum}");
                Console.WriteLine($"Last problem: {lastTask}");
            }

        }
    }
}
