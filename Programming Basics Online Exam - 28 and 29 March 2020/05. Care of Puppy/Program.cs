using System;

namespace _05._Care_of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            int foodAlive = input * 1000;
            int eatFood = 0;

            string curentEatFood = Console.ReadLine();
            while (curentEatFood != "Adopted")
            {
                eatFood += int.Parse(curentEatFood);

                curentEatFood = Console.ReadLine();
            }


            double diff = Math.Abs(foodAlive - eatFood);
            if (eatFood > foodAlive)
            {
                Console.WriteLine($"Food is not enough. You need {diff} grams more.");
            }
            else
            {
                Console.WriteLine($"Food is enough! Leftovers: {diff} grams.");
            }
        }
    }
}
