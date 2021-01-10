using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = string.Empty;
            string accommodation = string.Empty;
            string output = string.Empty;

            if (budget <= 1000)
            {
                if (season == "Summer")
                {
                    budget *= 0.65;
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    budget *= 0.45;
                    location = "Morocco";
                }
                accommodation = "Camp";
                output = $"{location} - {accommodation} - {budget:f2}";
            }

            else if (budget > 1000 && budget <= 3000)
            {
                if (season == "Summer")
                {
                    budget *= 0.80;
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    budget *= 0.60;
                    location = "Morocco";
                }
                accommodation = "Hut";
                output = $"{location} - {accommodation} - {budget:f2}";
            }
            else if (budget > 3000)
            {
                if (season == "Summer")
                {
                    budget *= 0.90;
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    budget *= 0.90;
                    location = "Morocco";
                }
                accommodation = "Hotel";
                output = $"{location} - {accommodation} - {budget:f2}";
            }
            Console.WriteLine(output);
        }
    }
}
