using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());

            double chikenMenuPrice = chickenMenu * 10.35;
            double fishMenuPrice = fishMenu * 12.40;
            double vegetarianMenuPrice = vegetarianMenu * 8.15;

            double sumMenuPrice = chikenMenuPrice + fishMenuPrice + vegetarianMenuPrice;

            double dessertPrice = sumMenuPrice * 0.20;

            double print = sumMenuPrice + dessertPrice + 2.50; //2.50 DeliveryPrice

            Console.WriteLine(print);

        }
    }
}
