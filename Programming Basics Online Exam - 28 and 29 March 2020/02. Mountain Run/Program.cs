using System;

namespace _02._Mountain_Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double metars = double.Parse(Console.ReadLine());
            double timeForPerMetars = double.Parse(Console.ReadLine());


            double timePlus = (Math.Floor( metars / 50)) * 30;
            double allTime = (metars * timeForPerMetars) + timePlus;


            double diff = Math.Abs(allTime - recordInSeconds);

            if (recordInSeconds <= allTime)
            {
                Console.WriteLine($"No! He was {diff:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($" Yes! The new record is {allTime:f2} seconds.");
            }
        }
    }
}

