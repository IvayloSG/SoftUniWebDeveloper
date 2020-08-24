using System;

namespace P06CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"Area = {area}");
            Console.WriteLine($"Perimeter = {perimeter}");
        }
    }
}
