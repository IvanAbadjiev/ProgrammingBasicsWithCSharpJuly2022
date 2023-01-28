using System;

namespace _01._Change_Bureau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int btcAlive = int.Parse(Console.ReadLine());
            double cnyAlice = double.Parse(Console.ReadLine());
            double changeComision = double.Parse(Console.ReadLine());

            double btcChangeForBgn = btcAlive * 1168;
            double cnyChangeForUsd = cnyAlice * 0.15;


            double usdSwapbgn = cnyChangeForUsd * 1.76;
            double bgnSwapEur = (usdSwapbgn + btcChangeForBgn) / 1.95;

            double print =  bgnSwapEur - (bgnSwapEur / 100  * changeComision);

            Console.WriteLine($"{print:f2}");
            
            
        }
    }
}
