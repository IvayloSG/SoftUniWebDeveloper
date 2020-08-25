using System;

namespace P11PlainSquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double sideOne = Math.Abs(x1 - y2);
            double sideTwo = Math.Abs(y1 - x2);

            double area = sideOne * sideTwo;
            double perimeter = 2 * sideOne + 2 * sideTwo;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
