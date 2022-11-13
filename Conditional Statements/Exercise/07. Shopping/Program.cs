using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double petarBudget = double.Parse(Console.ReadLine());
            int card = int.Parse(Console.ReadLine());
            int procesor = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double cardPrice = 250 * card;
            double procesorPrice = cardPrice *  0.35 * procesor;
            double ramPrice = cardPrice * 0.10 * ram;

            double totalSum = cardPrice + procesorPrice + ramPrice;

            if (card  > procesor)
            {
                totalSum *= 0.85;
            }

            double difference = petarBudget - totalSum;

            if (petarBudget >= totalSum)
            {
                Console.WriteLine($"You have {difference:F2} leva left!");
            } else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):F2} leva more!");
            }

            Console.WriteLine();
    

        }
    }
}
