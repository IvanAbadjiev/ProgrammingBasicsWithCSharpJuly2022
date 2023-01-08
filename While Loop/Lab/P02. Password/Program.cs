using System;

namespace _02._Password2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string username = Console.ReadLine();
            string savePassword = Console.ReadLine();

            while (true)
            {
            string curentPassword = Console.ReadLine();
                if (savePassword == curentPassword)
                {
                    Console.WriteLine($"Welcome {username}!");
                    break;
                }
            }
        }
    }
}
