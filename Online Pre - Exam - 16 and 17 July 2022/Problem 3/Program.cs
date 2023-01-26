using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var denceQty = int.Parse(Console.ReadLine());
            var pointQty = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var palce = Console.ReadLine();


            var moneyWin = 0.00;
            switch (palce)
            {
                case "Bulgaria":
                    moneyWin = pointQty * denceQty;

                    if (type == "summer")
                    {
                        moneyWin = moneyWin - moneyWin * 0.05;
                    }
                    else if (type == "winter")
                    {
                        moneyWin = moneyWin - moneyWin * 0.08;
                    }

                    break;
                case "Abroad":
                    moneyWin = denceQty * pointQty;
                    var procentMore = moneyWin / 2;
                    moneyWin += procentMore;

                    if (type == "summer")
                    {
                        moneyWin = moneyWin - moneyWin * 0.10;
                    }
                    else if (type == "winter")
                    {
                        moneyWin = moneyWin - moneyWin * 0.15;
                    }
                    break;
                default:
                    break;
            }

            var moneyCharity = moneyWin - moneyWin * 0.25;

            Console.WriteLine($"Charity - {moneyCharity:f2}");
            Console.WriteLine($"Money per dancer - {(moneyWin - moneyCharity) / denceQty:f2}");
        }
    }
}
