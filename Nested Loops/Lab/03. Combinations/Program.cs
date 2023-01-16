using System;

namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int one = 0; one <= n ; one++)
            {
                for (int two = 0; two <= n; two++)
                {
                    for (int third = 0; third <= n; third++)
                    {
                        if (one + two + third == n)
                        {
                            counter++;
                        }
                    }

                }

            }
            Console.WriteLine(counter);
        }
    }
}
