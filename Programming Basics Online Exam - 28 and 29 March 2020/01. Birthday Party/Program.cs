using System;

namespace _01._Birthday_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double cake = rent * 0.20;
            double drink = cake - cake * 0.45;
            double animation = rent / 3;

            double moneyNeed = cake + drink + animation + rent;

            Console.WriteLine(moneyNeed);

        }
    }
}
