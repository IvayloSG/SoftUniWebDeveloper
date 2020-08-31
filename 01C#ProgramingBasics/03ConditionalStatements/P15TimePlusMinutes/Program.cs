using System;

namespace P15TimePlusMinutes
{
    class Program
    {
        private const int additionalMinutes = 15;

        static void Main(string[] args)
        {
            int hourInput = int.Parse(Console.ReadLine());
            int minutesInput = int.Parse(Console.ReadLine());

            int resultedMinutes = minutesInput += additionalMinutes;
            int resultedHour = hourInput;

            if (resultedMinutes >= 60)
            {
                resultedMinutes -= 60;
                resultedHour += 1;
                if (resultedHour >= 23)
                {
                    resultedHour -= 24;
                }
            }

            Console.WriteLine(String.Format("{0}:{1:00}", resultedHour, resultedMinutes));
        }
    }
}
