using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int peint = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());

            double peintProcent = peint * 0.10;


            double nylonPrice = (nylon + 2) * 1.50;
            double peintPrice = (peint + peintProcent) * 14.50;
            double razreditelPrice = razreditel * 5.00;
            double bagPrice = 0.40;

            double sumMaterial = nylonPrice + peintPrice + razreditelPrice + bagPrice;


            double procentOfSum = sumMaterial / 100 * 30 * hour;

            double print = sumMaterial + procentOfSum;

            Console.WriteLine(print);


        }
    }
}
