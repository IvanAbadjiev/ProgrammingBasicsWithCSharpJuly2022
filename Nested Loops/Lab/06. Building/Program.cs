using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flor = int.Parse(Console.ReadLine());
            int apartament = int.Parse(Console.ReadLine());


            for (int curentFlor = flor; curentFlor >= 1; curentFlor--)
            {
                for (int curentApart = 0; curentApart < apartament; curentApart++)
                {
                    if (curentFlor == flor)
                    {
                        Console.Write($"L{curentFlor}{curentApart} ");
                    }
                    else if (curentFlor % 2 == 0)
                    {
                        Console.Write($"O{curentFlor}{curentApart} ");
                    }
                    else if (curentFlor % 2 != 0)
                    {
                        Console.Write($"A{curentFlor}{curentApart} ");
                    }


                }
                Console.WriteLine();


            }

        }
    }
}
