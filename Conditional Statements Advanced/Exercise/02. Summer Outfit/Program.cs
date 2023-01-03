using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int gredians = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string outfit = "Shirt"; //Evening
            string shoes = "Moccasins"; //Evening

            if (gredians <= 18)
            {
                switch (time)
                {
                    case "Morning":
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        break;
                    case "Afternoon":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    default:
                        break;
                }
            }
            else if (gredians <= 24)
            {
                switch (time)
                {
                    case "Morning":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case "Afternoon":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    default:
                        break;
                }

            }
            else
            {
                switch (time)
                {
                    case "Morning":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Afternoon":
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"It's {gredians} degrees, get your {outfit} and {shoes}."
);
        }
    }
}
