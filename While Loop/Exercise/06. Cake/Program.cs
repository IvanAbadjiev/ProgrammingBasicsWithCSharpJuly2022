using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int shi = int.Parse(Console.ReadLine());
           int dul = int.Parse(Console.ReadLine());

            int pieces = shi * dul;
            string curentPieces = Console.ReadLine();
            bool isVaid = false;

            while (curentPieces != "STOP")
            {
                pieces -= int.Parse(curentPieces);
                if (pieces <= 0)
                {
                    isVaid = true;
                    Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
                    break;
                }



                curentPieces = Console.ReadLine();
            }
            if (!isVaid)
            {
                Console.WriteLine($"{pieces} pieces are left.");

            }
        }
    }
}
