using System;

namespace P15DanceHall
{
    class Program
    {
        private const double dancerSpace = 7040;

        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double widght = double.Parse(Console.ReadLine());
            double cabinetSide = double.Parse(Console.ReadLine());

            double hallArea = (length * 100) * (widght * 100);

            double cabinetArea = (cabinetSide * 100) * (cabinetSide * 100);

            double seatArea = hallArea * 0.1;

            double dancers = Math.Floor((hallArea - seatArea - cabinetArea) / dancerSpace);

            Console.WriteLine(dancers);
        }
    }
}
