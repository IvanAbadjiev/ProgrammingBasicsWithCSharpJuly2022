using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNumber = 0;
            int lastNumber = int.MaxValue;
            while (input != "Stop")
            {
                int curentNumber = int.Parse(input);

                if (curentNumber < lastNumber)
                {
                   minNumber = curentNumber;
                }
                lastNumber = curentNumber;

                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);

        }
    }
}
