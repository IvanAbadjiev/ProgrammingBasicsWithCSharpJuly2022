using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int classes = 0;
            double avrgScore = 0.00;
            int conterForBan = 0;
            bool baned = true;

            while (classes != 12)
            {
                double curentYearElevetion = double.Parse(Console.ReadLine());
                if (curentYearElevetion >= 4.00)
                {
                    classes++;
                    avrgScore += curentYearElevetion;
                }
                else
                {
                    conterForBan++;
                    if (conterForBan > 1)
                    {
                        baned = false;
                        Console.WriteLine($"{input} has been excluded at {classes} grade");
                        break;
                    } else
                    {
                        classes++;
                    }
                }
            }
            if (baned)
            {
                Console.WriteLine($"{input} graduated. Average grade: {avrgScore / classes:f2}");
            }


        }
    }
}
