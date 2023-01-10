using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            money = money * 100;

            int counterMonet = 0;

            while (money > 0)
            {
                if (money >= 200)
                {
                    counterMonet++;
                    money -= 200;
                   // break;
                }
                else if (money >= 100)
                {
                    counterMonet++;
                    money -= 100;
                    //  break;
                }
                else if (money >= 50)
                {
                    counterMonet++;
                    money -= 50;
                    //  break;
                }
                else if (money >= 20)
                {
                    counterMonet++;
                    money -= 20;
                    //  break;
                }
                else if (money >= 10)
                {
                    counterMonet++;
                    money -= 10;
                    // break;
                }
                else if (money >= 5)
                {
                    counterMonet++;
                    money -= 5;
                    // break;
                }
                else if (money >= 2)
                {
                    counterMonet++;
                    money -= 2;
                    // break;
                }
                else if (money >= 1)
                {
                    counterMonet++;
                    money -= 1;
                    //break;
                }
                else
                {
                    money = 0.00;
                }


            }
            
            Console.WriteLine(counterMonet);
        
        
        }
    }
}
