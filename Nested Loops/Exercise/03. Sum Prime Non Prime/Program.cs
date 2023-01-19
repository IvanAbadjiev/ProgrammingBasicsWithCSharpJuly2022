using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int primeNum = 0;
            int nonPrimeNum = 0;

            
            while (input != "stop")
            {
                int curentNum = int.Parse(input);
                bool isNonPrimeNumber = true;
                if (curentNum < 0 )
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 2; i < curentNum; i++)
                {
                    if (curentNum % i == 0)
                    {
                        primeNum += curentNum;
                        isNonPrimeNumber = false;
                        break;
                    }
                    
                }

                if (isNonPrimeNumber)
                {
                    nonPrimeNum += curentNum;
                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"Sum of all prime numbers is: {nonPrimeNum}");
            Console.WriteLine($"Sum of all non prime numbers is: {primeNum}");
        }
    }
}
