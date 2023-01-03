using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

                int full = r * c;

            switch (type)
            {
                case "Premiere":
                    Console.WriteLine($"{(full * 12):F2} leva");
                    break;
                case "Normal":
                    Console.WriteLine($"{(full * 7.50):F2} leva");
                    break;
                case "Discount":
                    Console.WriteLine($"{(full * 5):F2} leva");
                    break;
                default:
                    break;
            }

        }
    }
}
