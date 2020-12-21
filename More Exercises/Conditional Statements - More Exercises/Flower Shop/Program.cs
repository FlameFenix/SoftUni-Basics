using System;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnoliaNumber = int.Parse(Console.ReadLine());
            int hyacinthNumber = int.Parse(Console.ReadLine());
            int RosesNumber = int.Parse(Console.ReadLine());
            int cactusNumber = int.Parse(Console.ReadLine());
            double GiftMoney = double.Parse(Console.ReadLine());

            double magnoliaSum = magnoliaNumber * 3.25;
            double hyacinthSum = hyacinthNumber * 4;
            double rosesSum = RosesNumber * 3.50;
            double cactusSum = cactusNumber * 8;

            double sumOfAll = (magnoliaSum + hyacinthSum + rosesSum + cactusSum) * 0.95;
            string output = string.Empty;

            if (GiftMoney <= sumOfAll)
            {
                sumOfAll = Math.Floor(sumOfAll - GiftMoney);
                output = $"She is left with {Math.Abs(sumOfAll)} leva.";
            }
            else
            {
                sumOfAll = Math.Ceiling(GiftMoney - sumOfAll);
                output = $"She will have to borrow {sumOfAll} leva.";
            }

            Console.WriteLine(output);
        }
    }
}
