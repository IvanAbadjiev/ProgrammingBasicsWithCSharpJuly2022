using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            string presentName = Console.ReadLine();
            double finalAvrScore = 0;
            int presentConter = 0;
            while (presentName != "Finish")
            {
            double curentPresenEv = 0;
                presentConter++;
                for (int i = 0; i < n; i++)
                {
                    double curentEv = double.Parse(Console.ReadLine());
                    curentPresenEv += curentEv;
                }

                Console.WriteLine($"{presentName:f2} - {curentPresenEv / n:f2}.");
                finalAvrScore += curentPresenEv / n;
                





                presentName = Console.ReadLine();
        
            }
            Console.WriteLine($"Student's final assessment is {finalAvrScore / presentConter:f2}.");
        }
        
    }
}
