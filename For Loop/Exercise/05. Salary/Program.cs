using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int selary = int.Parse(Console.ReadLine());

            bool printSelaryOrNotPrintSelary = true;

            for (int i = 0; i < tabs; i++)
            {
                string siteInCurentTabs = Console.ReadLine();



                switch (siteInCurentTabs)
                {
                    case "Facebook":
                        selary -= 150;
                        break;
                    case "Instagram":
                        selary -= 100;
                        break;
                    case "Reddit":
                        selary -= 50;
                        break;
                    default:
                        break;
                }
                if (selary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    printSelaryOrNotPrintSelary = false;
                    break;
                }
            }

            if (printSelaryOrNotPrintSelary)
            {
            Console.WriteLine(selary);

            }
        }
    }
}
