using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shirchBookForAni = Console.ReadLine();

            string aniBook = shirchBookForAni;

            int counterBookChek = 0;

            bool findAniBook = false;

            while (shirchBookForAni != "No More Books")
            {
                shirchBookForAni = Console.ReadLine();

                if (shirchBookForAni == "No More Books")
                {
                    break;
                }
                if (shirchBookForAni == aniBook)
                {
                    findAniBook = true;
                    Console.WriteLine($"You checked {counterBookChek} books and found it.");
                    break;
                }
                counterBookChek++;

            }

            if (!findAniBook)
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counterBookChek} books.");


            }
        }
    }
}
