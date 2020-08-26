using System;

namespace P06Number100to200
{
    class Program
    {
        private const int minLimit = 100;
        private const int maxLimit = 200;

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < minLimit)
            {
                Console.WriteLine($"Less than {minLimit}");
            }
            else if (number > maxLimit )
            {
                Console.WriteLine($"Greater than {maxLimit}");
            }
            else
            {
                Console.WriteLine($"Between {minLimit} and {maxLimit}");
            }
        }
    }
}
