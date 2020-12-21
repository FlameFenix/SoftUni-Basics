using System;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());
            string output = string.Empty;
            double vip = 499.99;
            double normal = 249.99;

            if (numberOfPeople >= 1 && numberOfPeople <= 4)
            {
                budget *= 0.25;
            }
            else if (numberOfPeople >= 5 && numberOfPeople <= 9)
            {
                budget *= 0.40;
            }
            else if (numberOfPeople >= 10 && numberOfPeople <= 24)
            {
                budget *= 0.50;


            }
            else if (numberOfPeople >= 25 && numberOfPeople <= 49)
            {
                budget *= 0.60;
            }
            else if (numberOfPeople >= 50)
            {
                budget *= 0.75;
            }

            if (category == "VIP")
            {
                budget -= vip * numberOfPeople;
                if (budget >= 0)
                {

                    output = $"Yes! You have {budget:f2} leva left.";
                }

                else
                {
                    output = $"Not enough money! You need {Math.Abs(budget):f2} leva.";
                }
            }
            else if (category == "Normal")
            {
                budget -= normal * numberOfPeople;
                if (budget >= 0)
                {
                    output = $"Yes! You have {budget:f2} leva left.";
                }
                else
                {
                    output = $"Not enough money! You need {Math.Abs(budget):f2} leva.";
                }

            }
            Console.WriteLine(output);
        }
    }
}
