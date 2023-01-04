using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayStay = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string evaluation = Console.ReadLine();

            double total = 0.00;

            //Намиране във какъв вид помещение ще е престоя
            //Важно 10 == 9 нощувки
            //начисляване на отстъпки според стаята и дните 
            //корекция на цената споре оценката

            switch (roomType)
            {
                case "room for one person":
                    total = (dayStay - 1) * 18;
                    break;
                case "apartment":
                    total = (dayStay - 1) * 25;
                    if ((dayStay - 1) < 10)
                    {
                        total -= total * 0.30;
                    }
                    else if ((dayStay - 1) <= 15)
                    {
                        total -= total * 0.35;
                    }
                    else
                    {
                        total -= total * 0.50;
                    }
                    break;
                case "president apartment":
                    total = (dayStay - 1) * 35;
                    if ((dayStay - 1) < 10)
                    {
                        total -= total * 0.10;
                    }
                    else if ((dayStay - 1) <= 15)
                    {
                        total -= total * 0.15;
                    }
                    else
                    {
                        total -= total * 0.20;
                    }
                    break;
                default:
                    break;
            }
            switch (evaluation)
            {
                case "positive":
                    total += total * 0.25;
                    break;
                case "negative":
                    total -= total * 0.10;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{total:f2}");


        }
    }
}
