using System;

namespace P17Scholarship
{
    class Program
    {
        private const int excellentScholarshipMultiplier = 25;
        private const double socialScholarshipMultiplier = 0.35;

        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double excellentScholarshipAmount = grade * excellentScholarshipMultiplier;
            double socialScholarshipAmount = salary * socialScholarshipMultiplier;

            bool isExcellentScholarship = grade >= 5.5;
            bool isSocialScholarship = grade >= 4.5 && income < salary;

            string result = string.Empty;

            if (isExcellentScholarship && isSocialScholarship)
            {
                if (excellentScholarshipAmount >= socialScholarshipAmount)
                {
                    result = $"You get a scholarship for excellent results {Math.Floor(excellentScholarshipAmount)} BGN";
                }
                else
                {
                    result = $"You get a Social scholarship {Math.Floor(socialScholarshipAmount)} BGN";
                }
            }
            else if (isExcellentScholarship)
            {
                result = $"You get a scholarship for excellent results {Math.Floor(excellentScholarshipAmount)} BGN";
            }
            else if (isSocialScholarship)
            {
                result = $"You get a Social scholarship {Math.Floor(socialScholarshipAmount)} BGN";
            }
            else
            {
                result = "You cannot get a scholarship!";
            }

            Console.WriteLine(result);
        }
    }
}
