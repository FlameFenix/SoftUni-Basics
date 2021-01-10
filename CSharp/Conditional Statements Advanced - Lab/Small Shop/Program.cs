using System;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double totalSum = 0.0;

            if (city == "Sofia")
            {
                if (productName == "coffee")
                {
                    totalSum = quantity * 0.50;
                }
                else if (productName == "water")
                {
                    totalSum = quantity * 0.80;
                }
                else if (productName == "beer")
                {
                    totalSum = quantity * 1.20;
                }
                else if (productName == "sweets")
                {
                    totalSum = quantity * 1.45;
                }
                else if (productName == "peanuts")
                {
                    totalSum = quantity * 1.60;
                }
            }

            else if (city == "Plovdiv")
            {
                if (productName == "coffee")
                {
                    totalSum = quantity * 0.40;
                }
                else if (productName == "water")
                {
                    totalSum = quantity * 0.70;
                }
                else if (productName == "beer")
                {
                    totalSum = quantity * 1.15;
                }
                else if (productName == "sweets")
                {
                    totalSum = quantity * 1.30;
                }
                else if (productName == "peanuts")
                {
                    totalSum = quantity * 1.50;
                }
            }

            else if (city == "Varna")
            {
                if (productName == "coffee")
                {
                    totalSum = quantity * 0.45;
                }
                else if (productName == "water")
                {
                    totalSum = quantity * 0.70;
                }
                else if (productName == "beer")
                {
                    totalSum = quantity * 1.10;
                }
                else if (productName == "sweets")
                {
                    totalSum = quantity * 1.35;
                }
                else if (productName == "peanuts")
                {
                    totalSum = quantity * 1.55;
                }
            }
            else
            {

            }
            Console.WriteLine(totalSum);
        }
    }
}
