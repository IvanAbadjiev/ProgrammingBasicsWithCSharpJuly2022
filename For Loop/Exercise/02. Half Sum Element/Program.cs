using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int curentNumber = int.Parse(Console.ReadLine());
                if (curentNumber > maxNumber)
                {
                    maxNumber = curentNumber;
                }

                sum += curentNumber;
            }
            int diff = Math.Abs(maxNumber - sum);
            if (maxNumber == sum-maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNumber - diff)}");
            }
        }
    }
}
