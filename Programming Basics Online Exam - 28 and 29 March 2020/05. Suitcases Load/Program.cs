using System;

namespace _05._Suitcases_Load
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            
            string curentBox = Console.ReadLine();
            int counter = 0;
            int counterForBox = 0;
            bool isValid = false;
            while (curentBox != "End")
            {
                double thisBox = double.Parse(curentBox);

                if (thisBox <= capacity)
                {
                    capacity -= thisBox;
                    counter++;



                }
                else
                {
                    Console.WriteLine("No more space!");
                    isValid = true;
                    break;
                }

                if (counter == 3)
                {
                    double thenProcent = thisBox * 0.10;
                    capacity -= thenProcent;
                    counter = 0;

                }

                


                counterForBox++;
                curentBox = Console.ReadLine();
            }


            if (!isValid)
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }

            Console.WriteLine($"Statistic: {counterForBox} suitcases loaded.");
        }
    }
}
