using System;

namespace P16Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cookers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double priceCake = 45;
            double priceWaffle = 5.8;
            double pricePancake = 3.2;

            double totalmoney = days * cookers * ((cakes * priceCake) + (waffles * priceWaffle) + (pancakes * pricePancake));
            double moneyForCharity = totalmoney - totalmoney / 8;

            Console.WriteLine($"{moneyForCharity:f2}");
        }
    }
}
