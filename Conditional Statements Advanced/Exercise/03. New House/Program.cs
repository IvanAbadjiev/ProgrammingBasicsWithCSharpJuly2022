using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int qyt = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0.00;

            switch (type)
            {
                case "Roses":
                    price = qyt * 5;
                    if (qyt > 80)
                    {
                        price -= price * 0.10;
                    }
                    break;
                case "Dahlias":
                    price = qyt * 3.80;
                    if (qyt > 90)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Tulips":
                    price = qyt * 2.80;
                    if (qyt > 80)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Narcissus":
                    price = qyt * 3;
                    if (qyt < 120)
                    {
                        price += price * 0.15;
                    }
                    break;
                case "Gladiolus":
                    price = qyt * 2.50;
                    if (qyt < 80)
                    {
                        price += price * 0.20;
                    }
                    break;
                default:
                    break;
            }

            if (price > budget)
            {
                Console.WriteLine($"Not enough money, you need {(price - budget):F2} leva more.");

            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {qyt} {type} and {(budget - price):F2} leva left.");
            }



        }
    }
}
