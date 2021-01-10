using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double moviePrice = double.Parse(Console.ReadLine());
            int participants = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());

            double discountClothes = 0;
            double clothesForAll = participants * clothesPrice;
            double decor = moviePrice * 0.1;
            double budgetPrice = 0;
            double finalSum = 0;

            if (participants > 150)
            {
                discountClothes = clothesForAll - (clothesForAll * 0.1);
                budgetPrice = decor + discountClothes;
                finalSum = moviePrice - budgetPrice;
            }

            else if (participants < 150)
            {
                budgetPrice = decor + clothesForAll;
                finalSum = moviePrice - budgetPrice;
            }


            if (moviePrice < budgetPrice)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(finalSum):f2} leva more.");
            }
            else if (budgetPrice <= moviePrice)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {finalSum:f2} leva left.");
            }
        }
    }
}
