using System;

namespace T04.InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double cm = double.Parse(Console.ReadLine());
            double inches = 2.54;

            double convertor = cm * inches;

            Console.WriteLine(convertor);

        }
    }
}
