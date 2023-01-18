using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                Double budget = double.Parse(Console.ReadLine());
                double saveMoney = 0;
                while (budget > saveMoney)
                {
                    saveMoney += double.Parse(Console.ReadLine());

                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }

        }
    }
}
