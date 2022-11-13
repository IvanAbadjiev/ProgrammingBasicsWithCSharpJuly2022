using System;

namespace _02._Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPoint = int.Parse(Console.ReadLine());

            double bonusPoint = 0.0;

            if (startPoint <= 100)
            {
                bonusPoint += 5;
            }
            else if (startPoint > 1000)
            {
                bonusPoint = startPoint * 0.10;
            }
            else
            {
                bonusPoint = startPoint * 0.20;
            }



            if (startPoint % 2 == 0)
            {
                bonusPoint++;
            }
            else if (startPoint % 10 == 5)
            {
                bonusPoint += 2;
            }


            Console.WriteLine(bonusPoint);
            Console.WriteLine(startPoint + bonusPoint);

        }
    }
}
