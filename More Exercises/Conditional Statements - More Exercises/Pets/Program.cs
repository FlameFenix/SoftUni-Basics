using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            int foodInKg = int.Parse(Console.ReadLine());
            double foodForDog = double.Parse(Console.ReadLine());
            double foodForCat = double.Parse(Console.ReadLine());
            double foodForTurtle = double.Parse(Console.ReadLine());

            double foodForTurtleInKg = foodForTurtle / 1000;
            double foodSum = days * (foodForDog + foodForCat + foodForTurtleInKg);
            string output = string.Empty;

            if (foodSum <= foodInKg)
            {
                foodSum = foodInKg - foodSum;
                output = $"{Math.Floor(foodSum)} kilos of food left.";
            }
            else
            {
                foodSum = Math.Ceiling(foodSum - foodInKg);
                output = $"{Math.Abs(foodSum)} more kilos of food are needed.";
            }
            Console.WriteLine(output);
        }
    }
}
