﻿using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string frut = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());

            double total = 0;
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (frut)
                    {
                        case "banana":
                            total = qty * 2.50;
                            break;
                        case "apple":
                            total = qty * 1.20;
                            break;
                        case "orange":
                            total = qty * 0.85;
                            break;
                        case "grapefruit":
                            total = qty * 1.45;
                            break;
                        case "kiwi":
                            total = qty * 2.70;
                            break;
                        case "pineapple":
                            total = qty * 5.50;
                            break;
                        case "grapes":
                            total = qty * 3.85;
                            break;

                        default:
                           // Console.WriteLine("error");
                            break;
                            
                    }
                  

                    break;
                case "Saturday":
                case "Sunday":
                    switch (frut)
                    {
                        case "banana":
                            total = qty * 2.70;
                            break;
                        case "apple":
                            total = qty * 1.25;
                            break;
                        case "orange":
                            total = qty * 0.90;
                            break;
                        case "grapefruit":
                            total = qty * 1.60;
                            break;
                        case "kiwi":
                            total = qty * 3.00;
                            break;
                        case "pineapple":
                            total = qty * 5.60;
                            break;
                        case "grapes":
                            total = qty * 4.20;
                            break;

                        default:
                            //Console.WriteLine("error");
                            break;
                    }
                    break;

                default:
                    //Console.WriteLine("error");
                    break;
            }


            if (total > 0)
            {
                Console.WriteLine($"{total:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}