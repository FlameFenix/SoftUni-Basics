using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupBudget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());
            double shipPrice = 0;

            if (season == "Spring")
            {

                if (fishermans <= 6)
                {
                    shipPrice = 3000 * 0.90;
                }

                else if (fishermans > 6 && fishermans <= 11)
                {
                    shipPrice = 3000 * 0.85;
                }

                else if (fishermans > 12)
                {
                    shipPrice = 3000 * 0.75;
                }
            }

            else if (season == "Summer" || season == "Autumn")
            {
                if (fishermans <= 6)
                {
                    shipPrice = 4200 * 0.90;
                }

                else if (fishermans > 6 && fishermans <= 11)
                {
                    shipPrice = 4200 * 0.85;
                }

                else if (fishermans > 12)
                {
                    shipPrice = 4200 * 0.75;
                }

            }
            else if (season == "Winter")
            {
                if (fishermans <= 6)
                {
                    shipPrice = 2600 * 0.90;
                }

                else if (fishermans > 6 && fishermans <= 11)
                {
                    shipPrice = 2600 * 0.85;
                }

                else if (fishermans > 12)
                {
                    shipPrice = 2600 * 0.75;
                }
            }

            string output = string.Empty;

            if (fishermans % 2 == 0)
            {
                if (season == "Summer" || season == "Winter" || season == "Spring")
                {
                    shipPrice *= 0.95;
                }
            }
            if (groupBudget < shipPrice)
            {
                shipPrice -= groupBudget;
                output = $"Not enough money! You need {Math.Abs(shipPrice):f2} leva.";
            }
            else if (groupBudget >= shipPrice)
            {
                groupBudget -= shipPrice;
                output = $"Yes! You have {groupBudget:f2} leva left.";
            }
            Console.Write(output);
        }
    }
}
