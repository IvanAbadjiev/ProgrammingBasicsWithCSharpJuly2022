using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());   
            int numberTwo = int.Parse(Console.ReadLine());   
            int magicNumber = int.Parse(Console.ReadLine());

            bool magicNumberAlive = false;
            int counter = 0;
            for (int one = numberOne; one <= numberTwo ; one++)
            {
                for (int two = numberOne; two <= numberTwo; two++)
                {
                    counter++;
                    if (one + two == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({one} + {two} = {magicNumber})");
                        magicNumberAlive = true;
                        break;
                    }

                }
                    if (magicNumberAlive)
                    {
                        break;
                    }

            }

            if (!magicNumberAlive)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }


        }
    }
}
