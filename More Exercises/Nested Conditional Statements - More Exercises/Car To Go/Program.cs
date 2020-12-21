using System;

namespace Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string output = string.Empty;
            string output2 = string.Empty;
            string typeOfVehicle = string.Empty;

            if (budget <= 100)
            {
                if (season == "Summer")
                {
                    budget *= 0.35;
                    typeOfVehicle = "Cabrio";
                }
                else if (season == "Winter")
                {
                    budget *= 0.65;
                    typeOfVehicle = "Jeep";
                }
                output = "Economy class";
                output2 = $"{typeOfVehicle} - {budget:f2}";
            }
            else if (budget > 100 && budget <= 500)
            {
                if (season == "Summer")
                {
                    budget *= 0.45;
                    typeOfVehicle = "Cabrio";
                }
                else if (season == "Winter")
                {
                    budget *= 0.80;
                    typeOfVehicle = "Jeep";
                }
                output = "Compact class";
                output2 = $"{typeOfVehicle} - {budget:f2}";
            }
            else if (budget > 500)
            {
                if (season == "Summer" || season == "Winter")
                {
                    budget *= 0.90;
                    typeOfVehicle = "Jeep";
                }
                output = "Luxury class";
                output2 = $"{typeOfVehicle} - {budget:f2}";
            }
            Console.WriteLine(output);
            Console.WriteLine(output2);
        }
    }
}
