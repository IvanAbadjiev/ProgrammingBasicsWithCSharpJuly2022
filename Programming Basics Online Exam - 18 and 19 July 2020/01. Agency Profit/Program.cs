using System;

namespace _01._Agency_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string agency = Console.ReadLine();
            int ticket = int.Parse(Console.ReadLine());
            int kidTicket = int.Parse(Console.ReadLine());
            double netoPriceForTicket = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());


            double priceRegularTicket = (netoPriceForTicket + tax) * ticket;
            double netPriceForKid = netoPriceForTicket - netoPriceForTicket * 0.70;
            double priceKidTicket = (netPriceForKid + tax) * kidTicket;

            double totalIncom = priceKidTicket + priceRegularTicket;

            double netIncom = totalIncom - totalIncom * 0.80;

            Console.WriteLine($"The profit of your agency from {agency} tickets is {netIncom:f2} lv.");

        }
    }
}
