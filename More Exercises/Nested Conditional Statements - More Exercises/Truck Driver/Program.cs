using System;

namespace Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            string output = string.Empty;

            if (kmPerMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    kmPerMonth *= 0.75 * 4;
                }
                else if (season == "Summer")
                {
                    kmPerMonth *= 0.90 * 4;
                }
                else if (season == "Winter")
                {
                    kmPerMonth *= 1.05 * 4;
                }
                kmPerMonth *= 0.90;
                output = $"{kmPerMonth:f2}";
            }
            else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    kmPerMonth *= 0.95 * 4;
                }
                else if (season == "Summer")
                {
                    kmPerMonth *= 1.10 * 4;
                }
                else if (season == "Winter")
                {
                    kmPerMonth *= 1.25 * 4;
                }
                kmPerMonth *= 0.90;
                output = $"{kmPerMonth:f2}";
            }
            else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
            {
                if (season == "Spring" || season == "Autumn" || season == "Winter" || season == "Summer")
                {
                    kmPerMonth *= 1.45 * 4;
                }
                kmPerMonth *= 0.90;
                output = $"{kmPerMonth:f2}";
            }
            Console.WriteLine(output);
        }
    }
}
