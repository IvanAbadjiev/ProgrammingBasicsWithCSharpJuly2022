using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string mouth = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double apartamentPrice = 0.00;
            double studioPrice = 0.00;

            //Стайте могат да бъдат 
            //Apartment
            //Studio
            //Месците (May, October) (June, September) (July, August)
            switch (mouth)
            {
                case "May":
                case "October":
                    apartamentPrice = 65 * days;
                    studioPrice = 50 * days;
                    if (days > 14)
                    {
                        apartamentPrice -= apartamentPrice * 0.10;
                        studioPrice -= studioPrice * 0.30;
                    }
                    else if (days > 7)
                    {
                        studioPrice -= studioPrice * 0.05;
                    }
                    
                    break;
                case "June":
                case "September":
                    apartamentPrice = 68.70 * days;
                    studioPrice = 75.20 * days;
                    if (days > 14)
                    {
                        apartamentPrice -= apartamentPrice * 0.10;
                        studioPrice -= studioPrice * 0.20;
                    }
                    
                    break;
                case "July":
                case "August":
                    apartamentPrice = 77 * days;
                    studioPrice = 76 * days;
                    if (days > 14)
                    {
                        apartamentPrice -= apartamentPrice * 0.10;
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Apartment: {apartamentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");


        }
    }
}
