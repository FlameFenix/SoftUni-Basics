using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = string.Empty;
            string destinationType = string.Empty;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    budget *= 0.30;
                    destinationType = "Camp";
                }
                else if (season == "winter")
                {
                    budget *= 0.70;
                    destinationType = "Hotel";
                }

            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    budget *= 0.40;
                    destinationType = "Camp";
                }
                else if (season == "winter")
                {
                    budget *= 0.80;
                    destinationType = "Hotel";
                }

            }
            else if (budget > 1000)
            {
                destination = "Europe";
                if (season == "summer")
                {
                    budget *= 0.90;
                    destinationType = "Hotel";
                }
                else if (season == "winter")
                {
                    budget *= 0.90;
                    destinationType = "Hotel";
                }

            }
            string output = string.Empty;
            string output2 = string.Empty;
            if (season == "summer")
            {
                output = $"Somewhere in {destination}";
                output2 = $"{destinationType} - {budget:f2}";
            }
            else if (season == "winter")
            {
                output = $"Somewhere in {destination}";
                output2 = $"{destinationType} - {budget:f2}";
            }
            Console.WriteLine(output);
            Console.WriteLine(output2);
        }
    }
}
