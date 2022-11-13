using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double StaffForOneStatistPrice = double.Parse(Console.ReadLine());


            double decorPrice = budget * 0.10;
            double staffPrice = StaffForOneStatistPrice * statist;

            if (statist > 150)
            {
                staffPrice *= 0.90;
            }

            double needMoney = decorPrice + staffPrice;
            double difference = budget - needMoney;

            if (needMoney > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(difference):F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:F2} leva left.");
            }




           
        }
    }
}
