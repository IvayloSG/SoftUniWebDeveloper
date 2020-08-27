using System;

namespace P10ToyShop
{
    class Program
    {
        private const double pricePuzzle = 2.6;
        private const double priceDoll = 3;
        private const double priceTeddy = 4.1;
        private const double priceMinion = 8.2;
        private const double priceTruck = 2;

        static void Main(string[] args)
        {
            double vacationCost = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int teddyCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            int toysTotalCount = puzzleCount + dollCount + teddyCount + minionCount + truckCount;

            double discount = 0;
            if (toysTotalCount >= 50)
            {
                discount = 0.25;
            }

            double revenue = puzzleCount * pricePuzzle + dollCount * priceDoll + teddyCount * priceTeddy + minionCount * priceMinion + truckCount * priceTruck;
            double discountedRevenue = revenue - revenue * discount;

            double profit = discountedRevenue - discountedRevenue * 0.1;

            if (profit >= vacationCost)
            {
                double moneyLeft = profit - vacationCost;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNeeded = vacationCost - profit;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed."); 
            }
        }
    }
}
