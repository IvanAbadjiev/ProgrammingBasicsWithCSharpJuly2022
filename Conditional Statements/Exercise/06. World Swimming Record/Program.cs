using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSecond = double.Parse(Console.ReadLine());
            double metars = double.Parse(Console.ReadLine());
            double timePerKilometer = double.Parse(Console.ReadLine());

            double time = timePerKilometer * metars;
            double waterProof = Math.Floor(metars / 15) * 12.5;

            double fullTime = time + waterProof;
            double difference = fullTime - recordInSecond;
            if (fullTime >= recordInSecond)
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(difference):F2} seconds slower.");
            }
            else if (fullTime < recordInSecond)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {fullTime:F2} seconds.");
            }

          
          
        }
    }
}
