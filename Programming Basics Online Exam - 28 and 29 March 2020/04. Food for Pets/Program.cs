using System;

namespace _04._Food_for_Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            double aliveFood = double.Parse(Console.ReadLine());

            double biscits = 0;
            int allDog = 0;
            int allCat = 0;
            double allFood = 0;
            int couter = 0;
            for (
                int i = 1; i <= day; i++)
            {
                couter++;
                int dog = int.Parse(Console.ReadLine());
                int cat = int.Parse(Console.ReadLine());

                allDog += dog;
                allCat += cat;
                allFood += dog + cat;

                if (couter == 3)
                {
                    biscits += (dog + cat) * 0.10;
                    couter = 0;
                }

            }

            double qutyAll = allFood / aliveFood * 100;
            double qutyDog = allDog  / allFood  * 100 ;
            double qutyCat = allCat / allFood * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscits)}gr.");
            Console.WriteLine($"{qutyAll:f2}% of the food has been eaten.");
            Console.WriteLine($"{qutyDog:f2}% eaten from the dog.");
            Console.WriteLine($"{qutyCat:f2}% eaten from the cat.");
        }
    }
}
