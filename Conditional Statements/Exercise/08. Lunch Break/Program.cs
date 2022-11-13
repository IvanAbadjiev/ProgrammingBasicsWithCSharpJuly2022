using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int serialTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunchTime = breakTime * 0.125 ;
            double brek = breakTime * 0.25;

            double timeForRest = serialTime + lunchTime + brek;

            if (timeForRest <= breakTime)
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(breakTime - timeForRest) } minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(timeForRest - breakTime)} more minutes.");
            }
          

        }
    }
}
