using System;

namespace P13CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            switch (inputCurrency)
            {
                case "USD": 
                    amount *= 1.79549;
                    break;
                case "EUR": 
                    amount *= 1.95583;
                    break;
                case "GBP": 
                    amount *= 2.53405;
                    break;
                default:
                    break;
            }

            double result = 0;

            switch (outputCurrency)
            {
                case "USD":
                    result = amount / 1.79549;
                    break;
                case "EUR":
                    result = amount / 1.95583;
                    break;
                case "GBP":
                    result = amount / 2.53405;
                    break;
                default:
                    result = amount;
                    break;
            }

            Console.WriteLine($"{result:f2} {outputCurrency}");
        }
    }
}
