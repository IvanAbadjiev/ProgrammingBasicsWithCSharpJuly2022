using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double selesValue = double.Parse(Console.ReadLine());

            double comision = 0;
            bool validCity = false;

            switch (city)
            {
                case "Sofia":
                    if (selesValue >= 0 && selesValue <= 500)
                    {
                        comision = selesValue * 0.05;
                    }
                    else if (selesValue > 500 && selesValue <= 1000)
                    {
                        comision = selesValue * 0.07;
                    }
                    else if (selesValue > 1000 && selesValue <= 10000)
                    {
                        comision = selesValue * 0.08;
                    }
                    else if (selesValue > 10000)
                    {
                        comision = selesValue * 0.12;
                    }



                    break;

                case "Varna":

                    if (selesValue >= 0 && selesValue <= 500)
                    {
                        comision = selesValue * 0.045;
                    }
                    else if (selesValue > 500 && selesValue <= 1000)
                    {
                        comision = selesValue * 0.075;
                    }
                    else if (selesValue > 1000 && selesValue <= 10000)
                    {
                        comision = selesValue * 0.10;
                    }
                    else if (selesValue > 10000)
                    {
                        comision = selesValue * 0.13;
                    }

                    break;

                case "Plovdiv":
                    if (selesValue >= 0 && selesValue <= 500)
                    {
                        comision = selesValue * 0.055;
                    }
                    else if (selesValue > 500 && selesValue <= 1000)
                    {
                        comision = selesValue * 0.08;
                    }
                    else if (selesValue > 1000 && selesValue <= 10000)
                    {
                        comision = selesValue * 0.12;
                    }
                    else if (selesValue > 10000)
                    {
                        comision = selesValue * 0.145;
                    }

                    break;




                default:
                    validCity = true;
                    break;
            }
            if (selesValue < 0 || validCity)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{comision:F2}");
            }

        }
    }
}
