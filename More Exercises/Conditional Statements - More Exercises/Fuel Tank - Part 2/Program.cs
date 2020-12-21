using System;

namespace Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelQuantity = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double diesel = 2.33;
            double gasoline = 2.22;
            double gas = 0.93;
            double finalSum = 0;
            string output = string.Empty;

            if (clubCard == "Yes")
            {
                if (fuelType == "Diesel")
                {
                    diesel -= 0.12;
                    finalSum = diesel * fuelQuantity;
                    if (fuelQuantity >= 20 && fuelQuantity <= 25)
                    {
                        finalSum *= 0.92;
                    }
                    else if (fuelQuantity > 25)
                    {
                        finalSum *= 0.90;
                    }
                    output = $"{finalSum:f2} lv.";
                }
                else if (fuelType == "Gasoline")
                {
                    gasoline -= 0.18;
                    finalSum = gasoline * fuelQuantity;
                    if (fuelQuantity >= 20 && fuelQuantity <= 25)
                    {
                        finalSum *= 0.92;
                    }
                    else if (fuelQuantity > 25)
                    {
                        finalSum *= 0.90;
                    }
                    output = $"{finalSum:f2} lv.";
                }
                else if (fuelType == "Gas")
                {
                    gas -= 0.08;
                    finalSum = gas * fuelQuantity;
                    if (fuelQuantity >= 20 && fuelQuantity <= 25)
                    {
                        finalSum *= 0.92;
                    }
                    else if (fuelQuantity > 25)
                    {
                        finalSum *= 0.90;
                    }
                    output = $"{finalSum:f2} lv.";
                }

            }
            else if (clubCard == "No")
            {
                if (fuelType == "Diesel")
                {
                    finalSum = diesel * fuelQuantity;
                    if (fuelQuantity >= 20 && fuelQuantity <= 25)
                    {
                        finalSum = finalSum * 0.92;
                    }
                    else if (fuelQuantity > 25)
                    {
                        finalSum = finalSum * 0.90;
                    }
                }
                else if (fuelType == "Gasoline")
                {
                    finalSum = gasoline * fuelQuantity;
                    if (fuelQuantity >= 20 && fuelQuantity <= 25)
                    {
                        finalSum = finalSum * 0.92;
                    }
                    else if (fuelQuantity > 25)
                    {
                        finalSum = finalSum * 0.90;
                    }
                }
                else if (fuelType == "Gas")
                {
                    finalSum = gas * fuelQuantity;
                    if (fuelQuantity >= 20 && fuelQuantity <= 25)
                    {
                        finalSum = finalSum * 0.92;
                    }
                    else if (fuelQuantity > 25)
                    {
                        finalSum = finalSum * 0.90;
                    }
                }
                output = $"{finalSum:f2} lv.";
            }
            Console.WriteLine(output);
        }
    }
}
