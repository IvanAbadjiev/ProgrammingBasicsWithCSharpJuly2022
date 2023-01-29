using System;

namespace _03._Fitness_Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aliveMoney = double.Parse(Console.ReadLine());
            string gendar = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sportType = Console.ReadLine();


            double mouthCardPrice = 0; 

            switch (sportType)
            {
                case "Gym":
                    if (gendar == "m")
                    {
                        mouthCardPrice = 42;
                    }
                    else if (gendar == "f")
                    {
                        mouthCardPrice = 35;
                    }
                    break;
                case "Boxing":
                    if (gendar == "m")
                    {
                        mouthCardPrice = 41;
                    }
                    else if (gendar == "f")
                    {
                        mouthCardPrice = 37;
                    }

                    break;
                case "Yoga":
                    if (gendar == "m")
                    {
                        mouthCardPrice = 45;
                    }
                    else if (gendar == "f")
                    {
                        mouthCardPrice = 42;
                    }

                    break;
                case "Zumba":
                    if (gendar == "m")
                    {
                        mouthCardPrice = 34;
                    }
                    else if (gendar == "f")
                    {
                        mouthCardPrice = 31;
                    }

                    break;
                case "Dances":
                    if (gendar == "m")
                    {
                        mouthCardPrice = 51;
                    }
                    else if (gendar == "f")
                    {
                        mouthCardPrice = 53;
                    }

                    break;
                case "Pilates":
                    if (gendar == "m")
                    {
                        mouthCardPrice = 39;
                    }
                    else if (gendar == "f")
                    {
                        mouthCardPrice = 37;
                    }

                    break;
                default:
                    break;
            }
            if (age <= 19)
            {
                mouthCardPrice -= mouthCardPrice * 0.20;
            }


            double diff = Math.Abs(aliveMoney - mouthCardPrice);

            if (mouthCardPrice <= aliveMoney)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sportType:f2}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${diff:f2} more.");
            }

        }
    }
}
