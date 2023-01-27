using System;

namespace _04._Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var balls = int.Parse(Console.ReadLine());


            var point = 0.00;
            var red = 0;
            var orange = 0;
            var yellow = 0;
            var white = 0;
            var other = 0;
            var blackDivides = 0;

            for (int i = 0; i < balls; i++)
            {
                var currentBall = Console.ReadLine();

                switch (currentBall)
                {
                    case "red":
                        point += 5;
                        red++;
                        break;
                    case "orange":
                        point += 10;
                        orange++;
                        break;
                    case "yellow":
                        point += 15;
                        yellow++;
                        break;
                    case "white":
                        point += 20;
                        white++;
                        break;
                    case "black":
                        point = Math.Floor(point / 2);
                        blackDivides++;
                        break;


                    default:
                        other++;
                        break;
                }



            }
            Console.WriteLine($"Total points: {point}");
            Console.WriteLine($"Red balls: {red}");
            Console.WriteLine($"Orange balls: {orange}");
            Console.WriteLine($"Yellow balls: {yellow}");
            Console.WriteLine($"White balls: {white}");
            Console.WriteLine($"Other colors picked: {other}");
            Console.WriteLine($"Divides from black balls: {blackDivides}");
        }
    }
}
