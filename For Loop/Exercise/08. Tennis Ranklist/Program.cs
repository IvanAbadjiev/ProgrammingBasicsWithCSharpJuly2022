using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtyTornament = int.Parse(Console.ReadLine());
            int startPoint = int.Parse(Console.ReadLine());

            int avrPoint = 0;
            double winProcent = 0.00;
            
            for (int i = 0; i < qtyTornament; i++)
            {
                string curentPosition = Console.ReadLine();

                switch (curentPosition)
                {
                    case "W":
                        winProcent++;
                        startPoint += 2000;
                        avrPoint += 2000;
                        break;
                    case "F":
                        
                        startPoint += 1200;
                        avrPoint += 1200;
                        break;
                    case "SF":
                       
                        startPoint += 720;
                        avrPoint += 720;
                        break;
                    default:
                        break;
                }
            }

            double print = avrPoint / qtyTornament;
            Console.WriteLine($"Final points: {startPoint}");
            Console.WriteLine($"Average points: {Math.Round(print)}");
            Console.WriteLine($"{(winProcent + 0.00) / qtyTornament * 100:f2}% ");
        }
    }
}
