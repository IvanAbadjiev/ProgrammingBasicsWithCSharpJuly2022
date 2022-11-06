using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
           int numberPen = int.Parse(Console.ReadLine());
            int numberMarker = int.Parse(Console.ReadLine());
            int preparation = int.Parse(Console.ReadLine());

            int discount = int.Parse(Console.ReadLine());

            double penPrice = numberPen * 5.80;
            double markerPrice = numberMarker * 7.20;
            double preparationPrice = preparation * 1.20;


            double ds =  discount / 100.00;


            double sum = penPrice + markerPrice + preparationPrice;

            double priceWithDiscount = sum - (sum * ds);

           

            Console.WriteLine(priceWithDiscount);
        }
    }
}
