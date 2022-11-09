using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            double print = 0;


            if(figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                print = side * side;


            } else if (figure == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());

                print = side1 * side2;

            } else if (figure == "circle")
            {
                double radios = double.Parse(Console.ReadLine());
                print = Math.PI * (Math.Pow(radios, 2));


            } else if (figure == "triangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());

                print = side1 * side2 / 2;

            }
            Console.WriteLine(print);
        }
    }
}
