using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int shi = int.Parse(Console.ReadLine());  
            int dul = int.Parse(Console.ReadLine());  
            int vis = int.Parse(Console.ReadLine());

            int freeCubicMeters = shi * dul * vis;
            int sumBoxCubicMeters = 0;
            bool isValid = false;

            string box = Console.ReadLine();
            while (box != "Done")
            {
                sumBoxCubicMeters += int.Parse(box);
                if (sumBoxCubicMeters > freeCubicMeters)
                {
                    isValid = true;
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeCubicMeters - sumBoxCubicMeters)} Cubic meters more."
    ); break;
                }
                box = Console.ReadLine();   
            }
            if (!isValid)
            {
                Console.WriteLine($"{freeCubicMeters - sumBoxCubicMeters} Cubic meters left.");

            }
            

        }
    }
}
