using System;

namespace Problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sea = int.Parse(Console.ReadLine());
            var mountain = int.Parse(Console.ReadLine());

            var place = Console.ReadLine();
            var totalMoney = 0;




            while (place != "Stop")
            {
                switch (place)
                {
                    case "sea":

                        if (sea > 0)
                        {
                            sea--;
                            totalMoney += 680;


                        }
                        break;
                    case "mountain":

                        if (mountain > 0)
                        {
                            mountain--;
                            totalMoney += 499;



                        }

                        break;
                    default:
                        break;
                }

                if (sea > 0 || mountain > 0)
                {
                    place = Console.ReadLine();

                }
                else
                {
                    break;
                }

            }

            if (sea < 1 && mountain! < 1)
            {
                Console.WriteLine("Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {totalMoney} leva.");
        }
    }
}
