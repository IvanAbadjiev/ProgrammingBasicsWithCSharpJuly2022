using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double needMoneyForTravel = double.Parse(Console.ReadLine());
            double aliveMoney = double.Parse(Console.ReadLine());


            int counterForSpend = 0;
            int counterForDay = 0;
            bool isValid = false;
            while (aliveMoney < needMoneyForTravel)
            {
                string spendOrSeve = Console.ReadLine();
                double curentMoney = double.Parse(Console.ReadLine());
                counterForDay++;
                switch (spendOrSeve)
                {
                    case "spend":
                        counterForSpend++;
                        aliveMoney -= curentMoney;
                        if (aliveMoney < 0)
                        {
                            aliveMoney = 0.00;
                        }
                        break;
                    case "save":
                        counterForSpend = 0;
                        aliveMoney += curentMoney;
                        break;
                    default:
                        break;
                }
                if (counterForSpend == 5)
                {
                    isValid = true;
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine($"{counterForDay}");

                    break;

                }
            }
                if (!isValid)
                {
                    Console.WriteLine($"You saved the money for {counterForDay} days.");
                }
        }
    }
}
