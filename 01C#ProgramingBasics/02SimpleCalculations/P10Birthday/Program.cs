using System;

namespace P10Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int widght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double aquariumVolume = length * widght * height;
            double waterVolume = (aquariumVolume - aquariumVolume * (percent / 100)) / 1000 ;

            Console.WriteLine($"{waterVolume:f3}");
        }
    }
}
