using System;

namespace P16ThreeBrothers
{
    class Program
    {
        private const double breakTime = 0.15;

        static void Main(string[] args)
        {
            double firstBrotherTime = Double.Parse(Console.ReadLine());
            double secondBrotherTime = Double.Parse(Console.ReadLine());
            double thirdBrotherTime = Double.Parse(Console.ReadLine());
            double fatherFishingTime = Double.Parse(Console.ReadLine());

            double cleaningTime = (1 / (1 / firstBrotherTime + 1 / secondBrotherTime + 1 / thirdBrotherTime));
            double totalCleaningTime = cleaningTime + (cleaningTime * breakTime);

            Console.WriteLine($"Cleaning time: {totalCleaningTime:f2}");

            if (totalCleaningTime < fatherFishingTime)
            {
                double timeLeft = Math.Floor(fatherFishingTime - totalCleaningTime);
                Console.WriteLine($"Yes, there is a surprise - time left -> {timeLeft} hours.");
            }
            else
            {
                double timeShortage = Math.Ceiling(totalCleaningTime - fatherFishingTime);
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {timeShortage} hours.");
            }
        }
    }
}
