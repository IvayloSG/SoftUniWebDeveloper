using System;

namespace P19SwimmingRecord
{
    class Program
    {
        private const double delayForFefteenMeters = 12.5;
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distanceRecord = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double toalDelay = Math.Floor((distanceRecord / 15)) * delayForFefteenMeters;

            double time = distanceRecord * secondsPerMeter + toalDelay;

            if (time >= worldRecord)
            {
                double timeNeeded = time - worldRecord;
                Console.WriteLine($"No, he failed! He was {timeNeeded:f2} seconds slower.");
            }
            else
            {
                double timeExcess = worldRecord - time;
                Console.WriteLine($"Yes, he succeeded! The new world record is {time:f2} seconds.");
            }

        }
    }
}
