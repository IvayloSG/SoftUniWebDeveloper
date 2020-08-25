using System;

namespace P14TailoringFacility
{
    class Program
    {
        private const double course = 1.85;

        static void Main(string[] args)
        {
            int tableCount = int.Parse(Console.ReadLine());
            double tableLength = double.Parse(Console.ReadLine());
            double tableWidght = double.Parse(Console.ReadLine());

            double totalTableSurface = (tableLength + 0.6) * (tableWidght + 0.6) * tableCount;

            double squareSide = tableLength / 2;
            double totalSquareSurface = (squareSide * squareSide) * tableCount;

            double usdPriceTables = totalTableSurface * 7;
            double usdPriceSquare = totalSquareSurface * 9;

            double totalUsdPrice = usdPriceSquare + usdPriceTables;
            double totalBgnPrice = totalUsdPrice * course;

            Console.WriteLine($"{totalUsdPrice:f2} USD");
            Console.WriteLine($"{totalBgnPrice:f2} BGN");
        }
    }
}
