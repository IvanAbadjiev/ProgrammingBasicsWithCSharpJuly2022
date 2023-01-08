using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sumOfAllNumber = 0;
            while (sumOfAllNumber < number )
            {
            int curentNumber = int.Parse(Console.ReadLine());
                sumOfAllNumber += curentNumber;
            }
            Console.WriteLine(sumOfAllNumber);
        }
    }
}