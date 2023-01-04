using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());    
            int examMin = int.Parse(Console.ReadLine());   
            
            int arrivalHour = int.Parse(Console.ReadLine());    
            int arrivalMin = int.Parse(Console.ReadLine());


            int examTime = (examHour * 60) + examMin;

            int arrivalTime = (arrivalHour * 60 + arrivalMin);

            string status = "";

            int difference = examTime - arrivalTime;

            if (difference <= 30 && difference >= 0)
            {
                status = "On time";
            }
            else if (difference > 30)
            {
                status = "Early";
            }
            else if (difference < 0)
            {
                status = "Late";
            }

            //до тук работи//

            //Изчисляване на разликата в часовете
            difference =  Math.Abs(difference);
            int difHour = difference / 60;
            int difMin = difference % 60;

            switch (status)
            {
                case "Late":
                    if (difHour < 1)
                    {
                        Console.WriteLine(status);
                        Console.WriteLine($"{difMin} minutes after the start");
                    }
                    else
                    {
                        Console.WriteLine(status);
                        Console.WriteLine($"{difHour}:{difMin:D2} hours after the start");
                    }
                    break;
                case "On time":
                    Console.WriteLine(status);
                    Console.WriteLine($"{difMin} minutes before the start");
                    break;
                case "Early":
                    if (difHour < 1)
                    {
                        Console.WriteLine(status);
                        Console.WriteLine($"{difMin} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine(status);
                        Console.WriteLine($"{difHour}:{difMin:d2} hours before the start");
                    }
                    break;


                default:
                    break;
            }
        }
    }
}
