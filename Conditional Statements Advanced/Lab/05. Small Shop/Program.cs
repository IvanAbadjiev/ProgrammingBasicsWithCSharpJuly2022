using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string produkt = Console.ReadLine();
            string city = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());

            double total = 0;
            switch (city)
            {
                case "Sofia":
                    switch (produkt)
                    {
                        case "coffee":
                            total = qty * 0.50;
                            break;
                        case "water":
                            total = qty * 0.80;
                            break;
                        case "beer":
                            total = qty * 1.20;
                            break;
                        case "sweets":
                            total = qty * 1.45;
                            break;
                        case "peanuts":
                            total = qty * 1.60;
                            break;

                        default:
                            break;
                    }
                    break;
                case "Plovdiv":
                    switch (produkt)
                    {
                        case "coffee":
                            total = qty * 0.40;
                            break;
                        case "water":
                            total = qty * 0.70;
                            break;
                        case "beer":
                            total = qty * 1.15;
                            break;
                        case "sweets":
                            total = qty * 1.30;
                            break;
                        case "peanuts":
                            total = qty * 1.50;
                            break;

                        default:
                            break;
                    }
                    break;
                case "Varna":
                    switch (produkt)
                    {
                        case "coffee":
                            total = qty * 0.45;
                            break;
                        case "water":
                            total = qty * 0.70;
                            break;
                        case "beer":
                            total = qty * 1.10;
                            break;
                        case "sweets":
                            total = qty * 1.35;
                            break;
                        case "peanuts":
                            total = qty * 1.55;
                            break;

                        default:
                            break;
                    }

                    break;
                default:
                    break;
            }
            Console.WriteLine(total);


        }
    }
}
