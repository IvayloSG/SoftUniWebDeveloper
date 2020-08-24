using System;

namespace P05TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseOne = double.Parse(Console.ReadLine());
            double baseTwo = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = (baseOne + baseTwo) * height / 2;

            Console.WriteLine(area);
        }
    }
}
