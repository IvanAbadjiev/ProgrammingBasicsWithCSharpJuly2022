using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            int puzel = int.Parse(Console.ReadLine());
            int dog = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            double sumPrice =
                puzel * 2.60 +
                dog * 3 +
                bear * 4.10 +
                minion * 8.20 +
                truck * 2;

            int sellToys = puzel + dog + bear + minion + truck;

            if (sellToys >= 50)
            {
                sumPrice *= 0.75;
            }

            sumPrice *= 0.90;

            double lessMoney = sumPrice - needMoney;

            if (sumPrice >= needMoney)
            {
                Console.WriteLine($"Yes! {lessMoney:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(lessMoney):F2} lv needed.");
            }
           
        }
    }
}
