using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int curentNum = 0;
            bool flag = false;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    curentNum++;
                    Console.Write(curentNum + " ");
                    if (curentNum >= n)
                    {
                        flag = true;
                        break;
                    }
                }
                    Console.WriteLine();
                if (flag)
                {
                    break;
                }
            }


        }
    }
}
