using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sumAllMoneyInBankAcount = 0.00;

            while (input != "NoMoreMoney")
            {
                double curentMoney = double.Parse(input);
                if (curentMoney <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    sumAllMoneyInBankAcount += curentMoney;
                    Console.WriteLine($"Increase: {curentMoney:f2}");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sumAllMoneyInBankAcount:f2}");
        }
    }
}