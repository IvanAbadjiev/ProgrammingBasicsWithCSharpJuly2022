using System;

namespace _03._Energy_Booster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frut = Console.ReadLine();
            string size = Console.ReadLine();
            int orderPack = int.Parse(Console.ReadLine());

            double totallPrice = 0;

            switch (frut)
            {
                case "Watermelon":
                    if (size == "small")
                    {
                        orderPack *= 2;
                        totallPrice = orderPack * 56;
                    }
                    else if (size == "big")
                    {
                        orderPack *= 5;
                        totallPrice = orderPack * 28.70;

                    }


                    break;
                case "Mango":
                    if (size == "small")
                    {
                        orderPack *= 2;
                        totallPrice = orderPack * 36.66;
                    }
                    else if (size == "big")
                    {
                        orderPack *= 5;
                        totallPrice = orderPack * 19.60;
                    }

                    break;
                case "Pineapple":
                    if (size == "small")
                    {
                        orderPack *= 2;
                        totallPrice = orderPack * 42.10;
                    }
                    else if (size == "big")
                    {
                        orderPack *= 5;
                        totallPrice = orderPack * 24.80;
                    }

                    break;
                case "Raspberry":
                    if (size == "small")
                    {
                        orderPack *= 2;
                        totallPrice = orderPack * 20;
                    }
                    else if (size == "big")
                    {
                        orderPack *= 5;
                        totallPrice = orderPack * 15.20;

                    }

                    break;
                default:
                    break;
            }

            if (totallPrice >= 400 && totallPrice <= 1000)
            {
                totallPrice = totallPrice - totallPrice * 0.15;
            }
            else if (totallPrice > 1000)
            {
                totallPrice = totallPrice - totallPrice * 0.50;
            }


            Console.WriteLine($"{totallPrice:f2} lv.");
        }
    }
}
