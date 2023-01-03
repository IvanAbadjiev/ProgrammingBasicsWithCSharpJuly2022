using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double boatPrice = 0.00;

            //Цената на лодката.
            switch (season)
            {
                case "Spring":
                    boatPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    boatPrice = 4200;
                    break;
                case "Winter":
                    boatPrice = 2600;
                    break;
                default:
                    break;
            }
            //Отстъпка според броя на рибарите.
            if (fishermen <= 6)
            {
                boatPrice -= boatPrice * 0.10;
            }
            else if (fishermen <= 11)
            {
                boatPrice -= boatPrice * 0.15;
            }
            else
            {
                boatPrice -= boatPrice * 0.25;
            }


            //Допълнителна отстъпка     
            if (season != "Autumn" && fishermen % 2 == 0)
            {
                boatPrice -= boatPrice * 0.05;
            }

            //Принтиране
            if (budget < boatPrice)
            {
                Console.WriteLine($"Not enough money! You need {(boatPrice - budget):F2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {(budget - boatPrice):F2} leva left.");
            }
           



        }
    }
}
