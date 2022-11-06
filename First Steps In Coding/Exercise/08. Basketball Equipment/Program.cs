using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());

            double sneakersPrice = annualFee - (annualFee * 0.40);
            double wear = sneakersPrice - (sneakersPrice * 0.20);
            double basscetbolBall = 0.25 * wear;
            double accessories = 0.20 * basscetbolBall;

            double print = annualFee + sneakersPrice + wear + basscetbolBall + accessories;



            Console.WriteLine(print);
        }
    }
}
