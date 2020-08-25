using System;

namespace P12USDtoBGNConverter
{
    class Program
    {
        private const double course = 1.79549;

        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());

            double bgn = usd * course;

            Console.WriteLine($"{bgn:f2} BGN");
        }
    }
}
