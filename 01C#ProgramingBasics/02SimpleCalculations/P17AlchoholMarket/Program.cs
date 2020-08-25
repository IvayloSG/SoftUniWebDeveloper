using System;

namespace P17AlchoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiaQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice * 0.5;
            double beerPrice = rakiaPrice * 0.2;
            double winePrice = rakiaPrice * 0.6;

            double totalmoney = whiskeyPrice * whiskeyQuantity + beerPrice * beerQuantity + rakiaPrice * rakiaQuantity + winePrice * wineQuantity;

            Console.WriteLine($"{totalmoney:f2}");
        }
    }
}
