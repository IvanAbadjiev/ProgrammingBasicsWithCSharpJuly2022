using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            int sumStep = 0;
            while (input != "Going home")
            {
                input = Console.ReadLine();
                if (input == "Going home")
                {
                    break;
                }
                sumStep += int.Parse(input);

                if (sumStep >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{sumStep - 10000} steps over the goal!");
                    break;
                } 

            }
            if (input == "Going home")
            {
                input = Console.ReadLine();
                sumStep += int.Parse(input);
                if (sumStep >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{Math.Abs(sumStep - 10000)} steps over the goal!");
                    
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(sumStep - 10000)} more steps to reach goal.");
                }
            }
        }
    }
}
