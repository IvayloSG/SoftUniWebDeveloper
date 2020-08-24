using System;

namespace P09RadiansConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());

            double degrees = 180.0 / Math.PI * radians;

            Console.WriteLine(Math.Round(degrees));
        }
    }
}
