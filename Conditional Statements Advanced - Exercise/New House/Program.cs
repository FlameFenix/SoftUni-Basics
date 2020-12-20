using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double sum = 0;

            if (typeOfFlowers == "Roses")
            {
                if (numberOfFlowers > 80)
                {
                    sum = (numberOfFlowers * 5) * 0.90;
                }
                else
                {
                    sum = numberOfFlowers * 5;
                }
            }

            else if (typeOfFlowers == "Dahlias")
            {
                if (numberOfFlowers > 90)
                {
                    sum = (numberOfFlowers * 3.80) * 0.85;
                }
                else
                {
                    sum = numberOfFlowers * 3.80;
                }
            }


            else if (typeOfFlowers == "Tulips")
            {
                if (numberOfFlowers > 80)
                {
                    sum = (numberOfFlowers * 2.80) * 0.85;
                }
                else
                {
                    sum = numberOfFlowers * 2.80;
                }
            }
            else if (typeOfFlowers == "Narcissus")
            {
                if (numberOfFlowers < 120)
                {
                    sum = (numberOfFlowers * 3.00) * 1.15;
                }
                else
                {
                    sum = numberOfFlowers * 3.00;
                }
            }

            else if (typeOfFlowers == "Gladiolus")
            {
                if (numberOfFlowers < 80)
                {
                    sum = (numberOfFlowers * 2.50) * 1.20;
                }
                else
                {
                    sum = numberOfFlowers * 2.50;
                }
            }
            double moneyLeft = 0;
            if (budget >= sum)
            {
                moneyLeft = budget - sum;
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {moneyLeft:f2} leva left.");
            }
            else
            {
                moneyLeft = sum - budget;
                Console.WriteLine($"Not enough money, you need {moneyLeft:f2} leva more.");
            }
        }
    }
}
