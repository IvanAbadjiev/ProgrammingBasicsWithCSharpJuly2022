using System;

namespace _03._Aluminum_Joinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var window = int.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var delivery = Console.ReadLine();

            var price = 0.00;



            if (window < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            switch (type)
            {
                case "90X130":
                    price = 110 * window;

                    if (window > 60)
                    {
                        price -= price * 0.08;
                    }
                    else if (window > 30)
                    {
                        price -= price * 0.05;
                    }
                    break;
                case "100X150":
                    price = 140 * window;
                    if (window > 80)
                    {
                        price -= price * 0.10;
                    }
                    else if (window > 40)
                    {
                        price -= price * 0.06;
                    }
                    break;
                case "130X180":
                    price = 190 * window;
                    if (window > 50)
                    {
                        price -= price * 0.12;
                    }
                    else if (window > 20)
                    {
                        price -= price * 0.07;
                    }

                    break;
                case "200X300":
                    price = 250 * window;
                    if (window > 50)
                    {
                        price -= price * 0.14;
                    }
                    else if (window > 25)
                    {
                        price -= price * 0.09;
                    }

                    break;
                default:
                    break;
            }

            if (delivery == "With delivery")
            {
                price += 60;
            }

            if (window > 99)
            {
                price -= price * 0.04;
            }

            Console.WriteLine($"{price:f2} BGN");
        }
    }
}
