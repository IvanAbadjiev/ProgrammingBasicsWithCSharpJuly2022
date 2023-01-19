using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            
            for (int i = num1; i <= num2; i++)
            {
                string curentNum = i.ToString();

                int evenSum = 0;
                int oddSum = 0;
                for (int j = 0; j < curentNum.Length; j++)
                {
                    int curentDigit = int.Parse(curentNum[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += curentDigit;
                    }
                    else
                    {
                        oddSum += curentDigit;
                    }

                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }


            }

        }
    }
}
