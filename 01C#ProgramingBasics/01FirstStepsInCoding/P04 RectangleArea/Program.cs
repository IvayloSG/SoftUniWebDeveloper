using System;

namespace P04_RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());

            double area = firstSide * secondSide;

            Console.WriteLine(area);
        }
    }
}
