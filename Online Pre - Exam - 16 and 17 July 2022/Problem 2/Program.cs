using System;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tShirtPrice = double.Parse(Console.ReadLine());
            var moneyOrWinBall = double.Parse(Console.ReadLine());

            var shortPrice = tShirtPrice - tShirtPrice * 0.25;
            var socksPricce = shortPrice - shortPrice * 0.80;
            var shoesPrice = (tShirtPrice + shortPrice) * 2;

            var totalBeforSell = tShirtPrice + socksPricce + shortPrice + shoesPrice;

            var totalAfterSell = totalBeforSell - totalBeforSell * 0.15;


            if (totalAfterSell >= moneyOrWinBall)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalAfterSell:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {Math.Abs(totalAfterSell - moneyOrWinBall):f2} lv. more.");
            }

        }
    }
}
