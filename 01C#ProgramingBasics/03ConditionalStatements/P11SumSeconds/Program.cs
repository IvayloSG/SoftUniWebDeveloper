using System;

namespace P11SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSeconds = int.Parse(Console.ReadLine());
            int secondSeconds = int.Parse(Console.ReadLine());
            int thirdSeconds = int.Parse(Console.ReadLine());

            int totalSeconds = firstSeconds + secondSeconds + thirdSeconds;

            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            string result = String.Format("{0}:{1:00}", minutes, seconds);
            Console.WriteLine(result);
        }
    }
}
