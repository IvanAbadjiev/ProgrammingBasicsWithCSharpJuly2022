using System;

namespace T08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            double dogPrice = dogFood * 2.50;
            double catPrice = catFood * 4;

            double sum = catPrice + dogPrice;

            Console.WriteLine($"{sum} lv.");
        }
    }
}
