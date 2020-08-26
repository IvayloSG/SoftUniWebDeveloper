using System;

namespace P08Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());

                area = side * side;
            }
            else if (figure == "rectangle")
            {
                double length = double.Parse(Console.ReadLine());
                double widght = double.Parse(Console.ReadLine());

                area = length * widght;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                area = Math.PI * Math.Pow(radius, 2);
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                area = side * height / 2;
            }

            Console.WriteLine($"{area:f2}");
        }
    }
}
