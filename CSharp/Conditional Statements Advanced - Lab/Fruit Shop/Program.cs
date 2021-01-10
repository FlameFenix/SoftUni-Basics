using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitName = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double totalPrice = 0.0;

            if (dayOfWeek == "Monday" ||
                dayOfWeek == "Tuesday" ||
                dayOfWeek == "Wednesday" ||
                dayOfWeek == "Thursday" ||
                dayOfWeek == "Friday")

            {
                if (fruitName == "banana")
                {
                    totalPrice = quantity * 2.50;
                }
                else if (fruitName == "apple")
                {
                    totalPrice = quantity * 1.20;
                }
                else if (fruitName == "orange")
                {
                    totalPrice = quantity * 0.85;
                }
                else if (fruitName == "grapefruit")
                {
                    totalPrice = quantity * 1.45;
                }
                else if (fruitName == "kiwi")
                {
                    totalPrice = quantity * 2.70;
                }
                else if (fruitName == "pineapple")
                {
                    totalPrice = quantity * 5.50;
                }
                else if (fruitName == "grapes")
                {
                    totalPrice = quantity * 3.85;
                }
            }
            else if (dayOfWeek == "Saturday" ||
                      dayOfWeek == "Sunday")
            {
                if (fruitName == "banana")
                {
                    totalPrice = quantity * 2.70;
                }
                else if (fruitName == "apple")
                {
                    totalPrice = quantity * 1.25;
                }
                else if (fruitName == "orange")
                {
                    totalPrice = quantity * 0.90;
                }
                else if (fruitName == "grapefruit")
                {
                    totalPrice = quantity * 1.60;
                }
                else if (fruitName == "kiwi")
                {
                    totalPrice = quantity * 3.00;
                }
                else if (fruitName == "pineapple")
                {
                    totalPrice = quantity * 5.60;
                }
                else if (fruitName == "grapes")
                {
                    totalPrice = quantity * 4.20;
                }
            }
            double finalSum = totalPrice;
            if (finalSum > 0)
            {
                Console.WriteLine($"{finalSum:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
