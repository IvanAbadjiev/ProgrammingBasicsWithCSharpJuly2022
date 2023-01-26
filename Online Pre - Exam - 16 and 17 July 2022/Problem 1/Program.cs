using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var procesUsdPrice = double.Parse(Console.ReadLine());
            var videoCardUsdPrice = double.Parse(Console.ReadLine());
            var ramUsdPrice = double.Parse(Console.ReadLine());
            var ramQty = int.Parse(Console.ReadLine());
            var procSell = double.Parse(Console.ReadLine());

            var procesBgnPrice = procesUsdPrice * 1.57;
            var videoCardBgnPrice = videoCardUsdPrice * 1.57;
            var ramBgnPrice = ramUsdPrice * 1.57;
            var ramSumBgnPrice = ramBgnPrice * ramQty;

            var sellProces = procesBgnPrice - procesBgnPrice * procSell;
            var sellVideoCard = videoCardBgnPrice - videoCardBgnPrice * procSell;


            var total = sellProces + sellVideoCard + ramSumBgnPrice;
            Console.WriteLine($"Money needed - {total:f2} leva.");

        }
    }
}
