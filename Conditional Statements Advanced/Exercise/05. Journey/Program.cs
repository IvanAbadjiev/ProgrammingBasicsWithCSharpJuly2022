using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();


            string destination = "";
            string typeJourny = "";
            double money = 0.00;

            // Бюджета определя дестинацията
            // сезона определя колко от бюджета ще изхарчи
            //Sumer -> Camp
            //Winter -> Hotel
            // Europe -> Hotel

            //Намиране на дестинацията според Бюджета
            if (budget <= 100)
            {
                destination = "Bulgaria";
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
            }
            else
            {
                destination = "Europe";
                typeJourny = "Hotel";
                money =  budget * 0.90;
            }

            //Намиране на сезона и процента от бюджета
            switch (destination)
            {
                case "Bulgaria":
                    if (season == "summer")
                    {
                        money =  budget * 0.30;
                        typeJourny = "Camp";
                    }
                    else
                    {
                        money =  budget * 0.70;
                        typeJourny = "Hotel";
                    }
                    break;
                case "Balkans":
                    if (season == "summer")
                    {
                        money =  budget * 0.40;
                        typeJourny = "Camp";
                    }
                    else
                    {
                        money =  budget * 0.80;
                        typeJourny = "Hotel";
                    }
                    break;
                default:
                    break;
            }

            //принтиране
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeJourny} - {money:F2}");


        }
    }
}
