using System;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());

            var degreesAvereg = 0.00;
            var sumLiter = 0.00;
            for (int i = 1; i <= days; i++)
            {
                var alcoholQty = double.Parse(Console.ReadLine());
                var degrees = double.Parse(Console.ReadLine());

                sumLiter += alcoholQty;

                degreesAvereg += alcoholQty * degrees;
            }
            var sumDegrees = degreesAvereg / sumLiter;

            Console.WriteLine($"Liter: {sumLiter:f2}");
            Console.WriteLine($"Degrees: {sumDegrees:f2}");
            if (sumDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (sumDegrees >= 38 && sumDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (sumDegrees > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
