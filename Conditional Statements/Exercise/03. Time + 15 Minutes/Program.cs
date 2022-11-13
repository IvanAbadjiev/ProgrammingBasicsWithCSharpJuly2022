using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int addFiveteanMinet = m + (h * 60) + 15;

            double hourAfterAdd = addFiveteanMinet / 60;
            double minAfterAdd = addFiveteanMinet % 60;

            if (hourAfterAdd > 23)
            {
                hourAfterAdd = 0;
            }

            if (minAfterAdd < 10)
            {
                Console.WriteLine($"{hourAfterAdd}:0{minAfterAdd}");
            }
            else
            {
                Console.WriteLine($"{hourAfterAdd}:{minAfterAdd}");
            }


           

        }
    }
}
