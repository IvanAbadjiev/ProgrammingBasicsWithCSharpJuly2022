using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int listNumberInBook = int.Parse(Console.ReadLine());
            int listReadPerHour = int.Parse(Console.ReadLine());
            int dayReadBook = int.Parse(Console.ReadLine());

            int calculate = listNumberInBook / listReadPerHour;

            int day = calculate / dayReadBook;

            Console.WriteLine(day);

        }
    }
}
