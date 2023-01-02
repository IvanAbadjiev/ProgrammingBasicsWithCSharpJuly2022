using System;

namespace _08.Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();

            int priceTicet = 0;
            switch (dayOfWeek)
            {
                case "Monday":
                    priceTicet = 12;
                    break;
                case "Tuesday":
                    priceTicet = 12;
                    break;
                case "Wednesday":
                    priceTicet = 14;
                    break;
                case "Thursday":
                    priceTicet = 14;
                    break;
                case "Friday":
                    priceTicet = 12;
                    break;
                case "Saturday":
                case "Sunday":
                    priceTicet = 16;
                    break;
                default:
                    break;
            }
            Console.WriteLine(priceTicet);
        }
    }
}
