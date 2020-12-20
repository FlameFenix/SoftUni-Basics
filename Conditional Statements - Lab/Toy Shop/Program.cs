using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceNeeded = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzlesPrice = puzzles * 2.60;
            double dollsPrice = dolls * 3;
            double bearsPrice = bears * 4.10;
            double minionsPrice = minions * 8.20;
            double trucksPrice = trucks * 2;

            double sum = puzzlesPrice + dollsPrice + bearsPrice + minionsPrice + trucksPrice;
            int numberOfToys = puzzles + dolls + bears + minions + trucks;

            if (numberOfToys >= 50)
            {
                sum = sum * 0.75;
            }

            sum = sum * 0.9;

            if (sum >= priceNeeded)
            {
                double VacationMoney = sum - priceNeeded;
                Console.WriteLine($"Yes! {VacationMoney:F2} lv left.");
            }
            else
            {
                double neededMoney = priceNeeded - sum;
                Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");
            }
        }
    }
}
