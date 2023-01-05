using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;


            for (int i = 0; i < n; i++)
            {
                int curentNumber = int.Parse(Console.ReadLine());

                if (curentNumber > maxNumber)
                {
                    maxNumber = curentNumber;
                }
                 if (curentNumber < minNumber)
                {
                    minNumber = curentNumber;
                }

            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
