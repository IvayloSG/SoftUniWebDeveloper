using System;

namespace P03BiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int max = Math.Max(firstNumber, secondNumber);

            Console.WriteLine(max);
        }
    }
}
