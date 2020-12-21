using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int xVineyard = int.Parse(Console.ReadLine());
            double yGraphes = double.Parse(Console.ReadLine());
            int zLittersWine = int.Parse(Console.ReadLine());
            int numberOfPersonal = int.Parse(Console.ReadLine());

            double sumGraphes = 0;
            double wine = 0;
            sumGraphes = xVineyard * yGraphes;
            double littresPerPersonal = 0;
            double littresPerOnePerson = 0;

            string output = string.Empty;

            wine = 0.40 * sumGraphes / 2.5;
            if (wine >= zLittersWine)
            {
                littresPerPersonal = wine - zLittersWine;
                littresPerOnePerson = littresPerPersonal / numberOfPersonal;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(littresPerPersonal)} liters left -> {Math.Ceiling(littresPerOnePerson)} liters per person.");
            }
            else
            {
                wine = zLittersWine - wine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wine)} liters wine needed.");
            }
        }
    }
}
