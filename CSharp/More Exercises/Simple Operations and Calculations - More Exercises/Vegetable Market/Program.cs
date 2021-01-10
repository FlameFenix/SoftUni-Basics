using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            double vegetableKg = double.Parse(Console.ReadLine());
            double fruitsKg = double.Parse(Console.ReadLine());

            double vegetableFinalSum = vegetablePrice * vegetableKg;
            double fruitsFinalSum = fruitsPrice * fruitsKg;

            double finalSumInBGN = vegetableFinalSum + fruitsFinalSum;
            double finalSumInEU = finalSumInBGN / 1.94;

            Console.WriteLine($"{finalSumInEU:F2}");
        }
    }
}
