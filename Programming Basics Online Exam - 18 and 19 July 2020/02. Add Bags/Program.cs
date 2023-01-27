using System;

namespace _02._Add_Bags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var priceOver20Kg = double.Parse(Console.ReadLine());
            var baggageKg = double.Parse(Console.ReadLine());
            var dayToTravel = int.Parse(Console.ReadLine());
            var qtyBaggage = int.Parse(Console.ReadLine());

            var price = 0.00;
            if (baggageKg < 10)
            {
                price = priceOver20Kg - priceOver20Kg * 0.80;
                price = price * qtyBaggage;
            }
            else if (baggageKg <= 20)
            {
                price = priceOver20Kg / 2;
                price = price * qtyBaggage;
            }
            else
            {
                price = priceOver20Kg * qtyBaggage;
            }


            if (dayToTravel > 30)
            {
                price = price + price * 0.10;
            }
            else if (dayToTravel <= 30 && dayToTravel >= 7)
            {
                price = price + price * 0.15;
            }
            else if (dayToTravel < 7)
            {
                price = price + price * 0.40;
            }

            Console.WriteLine($"The total price of bags is: {price:f2} lv.");
        }
    }
}
