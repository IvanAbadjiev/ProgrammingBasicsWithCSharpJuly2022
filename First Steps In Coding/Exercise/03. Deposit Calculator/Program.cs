using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositMoney = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            double year = double.Parse(Console.ReadLine());

            double procent = year / 100;

            double sum = depositMoney + time * ((depositMoney * procent) / 12);

            Console.WriteLine(sum);
        }
    }
}
