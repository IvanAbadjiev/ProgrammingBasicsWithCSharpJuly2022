using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();


            double result = 0.00;
            string evenOrOdd = "even";

            
            
            //Деление(/),
            //Модулно деление(%),
            // / Print num1 operation num2 = result if num2 == 0 Print -> "Cannot divide num1 by zero"
            // % Print num1 operation num2 = result if num2 == 0 Print -> "Cannot divide num1 by zero"

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    if (result % 2 == 1)
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
                    break;
                case "-":
                    result = num1 - num2;
                    if (result % 2 == 1 || result % 2 == -1)
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
                    break;
                case "*":
                    result = num1 * num2;
                    if (result % 2 == 1)
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {

                        result =  (num1 + 0.00) / num2;
                        Console.WriteLine($"{num1} {operation} {num2} = {result:F2}");
                    }
                    break;
                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        result = num1  % num2;
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                    }


                    break;


                default:
                    break;
            }

        }
    }
}
