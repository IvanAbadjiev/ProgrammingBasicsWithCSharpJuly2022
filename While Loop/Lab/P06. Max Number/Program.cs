using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNumber = 0;
            int lastNumber = int.MinValue;
            while (input != "Stop")
            {
                int curentNumber = int.Parse(input);

                if(curentNumber > lastNumber)
                {
                    maxNumber = curentNumber;
                }
                lastNumber = curentNumber;

                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);


        }
    }
}
