using System;

namespace _05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var playarName = Console.ReadLine();
            var goal = int.Parse(Console.ReadLine());

            var bestPlayerName = string.Empty;
            var lastBestGoal = 0;

            bool isHatTrick = false;
            bool isMoreThan10Goal = false;
            while (playarName != "END")
            {
                if (goal > lastBestGoal)
                {
                    lastBestGoal = goal;
                    bestPlayerName = playarName;
                }

                if (goal >= 3)
                {
                    isHatTrick = true;
                }
                if (goal >= 10)
                {
                    isMoreThan10Goal = true;
                    break;
                }

                playarName = Console.ReadLine();
                if (playarName != "END")
                {
                    goal = int.Parse(Console.ReadLine());

                }

            }

            Console.WriteLine($"{bestPlayerName} is the best player!");

            if (isHatTrick)
            {
                Console.WriteLine($"He has scored {lastBestGoal} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {lastBestGoal} goals.");
            }

        }
    }
}
