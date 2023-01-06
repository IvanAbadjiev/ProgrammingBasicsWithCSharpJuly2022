using System;

namespace _03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;



            for (int i = 0; i < n; i++)
            {
                int curentNumber = int.Parse(Console.ReadLine());

                if (curentNumber < 200)
                {
                    p1++;
                }
                else if (curentNumber < 400)
                {
                    p2++;
                }
                else if (curentNumber < 600)
                {
                    p3++;
                }
                else if (curentNumber < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            // До тук работи
            
            Console.WriteLine($"{(p1 + 0.00) / n * 100:f2}%");
            Console.WriteLine($"{(p2 + 0.00) / n * 100:f2}%");
            Console.WriteLine($"{(p3 + 0.00) / n * 100:f2}%");
            Console.WriteLine($"{(p4 + 0.00) / n * 100:f2}%");
            Console.WriteLine($"{(p5 + 0.00) / n * 100:f2}%");
        }
    }
}
