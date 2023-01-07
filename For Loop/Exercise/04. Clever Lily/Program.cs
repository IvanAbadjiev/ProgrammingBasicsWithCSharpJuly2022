using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int liliAge = int.Parse(Console.ReadLine());
            double washingMashinePrice = double.Parse(Console.ReadLine());
            int toysPriceForOneToy = int.Parse(Console.ReadLine());

            int toysCounter = 0;
            int moneySum = 0;
            int moneyPerBirdDay = 10;

            for (int i = 1; i <= liliAge; i++)
            {
                if (i % 2 != 0)
                {
                    toysCounter++;
                }
                else
                {
                    moneySum += moneyPerBirdDay;
                    moneyPerBirdDay += 10;
                    moneySum--;
                }



            }
            //До тук работи 

            int totalSpendMoney = (toysCounter * toysPriceForOneToy) + moneySum;
            double diff = Math.Abs(totalSpendMoney - washingMashinePrice);
            if (totalSpendMoney < washingMashinePrice)
            {
                Console.WriteLine($"No! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
        }
    }
}
