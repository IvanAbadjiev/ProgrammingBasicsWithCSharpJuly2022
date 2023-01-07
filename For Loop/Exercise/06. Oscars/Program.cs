using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actiorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int elevationPeople = int.Parse(Console.ReadLine());

            bool congratilation = false;

            for (int i = 0; i < elevationPeople; i++)
            {
                string elevationName = Console.ReadLine();
                double curentPoint = double.Parse(Console.ReadLine());

                double sum = (elevationName.Length * curentPoint) / 2;
                academyPoints += sum;
                if (academyPoints > 1250.5)
                {
                    congratilation = true;
                    break;
                }

            }

            double diff = Math.Abs(academyPoints - 1250.5);
            if (congratilation)
            {
                Console.WriteLine($"Congratulations, {actiorName} got a nominee for leading role with {academyPoints:f1}!"
);
            }
            else
            {
                Console.WriteLine($"Sorry, {actiorName} you need {diff:f1} more!"
);
            }
        }
    }
}
