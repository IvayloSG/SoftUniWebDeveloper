using System;

namespace P14UnitConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            switch (inputUnit)
            {
                case "m":
                    value = value / 1;
                    break;
                case "mm":
                    value = value / 1000;
                    break;
                case "cm":
                    value = value / 100;
                    break;
                case "mi":
                    value = value / 0.000621371192;
                    break;
                case "in":
                    value = value / 39.3700787;
                    break;
                case "km":
                    value = value / 0.001;
                    break;
                case "ft":
                    value = value / 3.2808399;
                    break;
                case "yd":
                    value = value / 1.0936133;
                    break;
                default:
                    break;
            }

            switch (outputUnit)
            {
                case "m":
                    value = value * 1;
                    break;        
                case "mm":        
                    value = value * 1000;
                    break;        
                case "cm":        
                    value = value * 100;
                    break;        
                case "mi":        
                    value = value * 0.000621371192;
                    break;        
                case "in":        
                    value = value * 39.3700787;
                    break;        
                case "km":        
                    value = value * 0.001;
                    break;        
                case "ft":        
                    value = value * 3.2808399;
                    break;        
                case "yd":        
                    value = value * 1.0936133;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{value:f8}");
        }
    }
}
