using System;

namespace Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double litters = double.Parse(Console.ReadLine());

            string output = string.Empty;

            if (litters >= 25)
            {
                if (fuelType == "Diesel" || fuelType == "Gasoline" || fuelType == "Gas")
                {
                    output = $"You have enough {fuelType.ToLower()}.";
                }
                else
                {
                    output = "Invalid fuel!";
                }
            }
            else
            {
                if (fuelType == "Diesel" || fuelType == "Gasoline" || fuelType == "Gas")
                {
                    output = $"Fill your tank with {fuelType.ToLower()}!";
                }
                else
                {
                    output = "Invalid fuel!";
                }

            }
            Console.WriteLine(output);
        }
    }
}
