﻿using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k<= 9; k++)
                    {
                        for (int m = 1; m <= 9 ; m++)
                        {
                            if (n%i  == 0 && n%j == 0 && n%k==0 && n%m == 0)
                            {
                                Console.Write($"{i}{j}{k}{m} ");
                            }

                        }
                    }
                }

            }

        }
    }
}
