using System;

namespace P02_InchesToCm
{
    class Program
    {
        static void Main(string[] args)
        {
            double inchesInput = double.Parse(Console.ReadLine());
            double centimeters = inchesInput * 2.54;
            Console.WriteLine(centimeters);
        }
    }
}
