using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double procent = double.Parse(Console.ReadLine());

            double volumeOfTheAquarium = length * width * height;

            double convertToLiters = volumeOfTheAquarium / 1000;

            double pro = procent / 100;

            double occupiedPlace = convertToLiters * pro ;

            Console.WriteLine(convertToLiters - occupiedPlace );

            
        }
    }
}
