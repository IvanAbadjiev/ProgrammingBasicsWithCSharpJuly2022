using System;

namespace _02._Cat_Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minWallkPearExit = int.Parse(Console.ReadLine());
            int exit = int.Parse(Console.ReadLine());   
            int calorieConsumation = int.Parse(Console.ReadLine());

            int sumMinetWallk = minWallkPearExit * exit;
            int burnCaloriesForDay = sumMinetWallk * 5;
            int targetCalories = calorieConsumation / 2;

            if (burnCaloriesForDay >= targetCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnCaloriesForDay}.");
            } else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnCaloriesForDay}.");
            }

        }
    }
}
