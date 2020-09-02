using System;

namespace P18Choreography
{
    class Program
    {
        private const double maxStepsPercentage = 13;
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double stepsPerDayPercentage = Math.Ceiling(((double)steps / days) / steps * 100);
            double stepsPerDancerPercentage = stepsPerDayPercentage / dancers;

            if (stepsPerDancerPercentage <= maxStepsPercentage)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsPerDancerPercentage:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, they will not succeed in that goal! Required {stepsPerDancerPercentage:f2}% steps to be learned per day.");
            }
        }
    }
}
