using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int workersNumber = int.Parse(Console.ReadLine());
            double education = days * 0.90;
            double workingHours = education * 8;
            double overtime = workersNumber * (2 * days);
            double hoursForProject = workingHours + overtime;
            string output = string.Empty;

            if (hoursForProject >= hours)
            {
                hoursForProject = hoursForProject - hours;
                output = $"Yes!{Math.Floor(hoursForProject)} hours left.";
            }
            else
            {
                hoursForProject = Math.Floor(hoursForProject - hours);
                output = $"Not enough time!{Math.Abs(hoursForProject)} hours needed.";
            }
            Console.WriteLine(output);
        }
    }
}
