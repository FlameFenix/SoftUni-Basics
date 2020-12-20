using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string Room = Console.ReadLine();
            string rating = Console.ReadLine();

            double nights = days - 1;
            double sumNights = 0.0;

            if (Room == "room for one person" ||
                Room == "apartment" ||
                Room == "president apartment")
            {
                if (Room == "room for one person")
                {
                    sumNights = nights * 18.00;
                }
                else if (Room == "apartment")
                {
                    if (days >= 0 && days <= 10)

                    {
                        sumNights = (nights * 25.00) - (nights * 25.00) * 0.30;
                    }
                    else if (days > 10 && days <= 15)
                    {
                        sumNights = (nights * 25.00) - (nights * 25.00) * 0.35;
                    }
                    else if (days > 15)
                    {
                        sumNights = (nights * 25.00) - (nights * 25.00) * 0.50;
                    }
                }

                else if (Room == "president apartment")
                {
                    if (days >= 0 && days <= 10)
                    {
                        sumNights = (nights * 35.00) - (nights * 35.00) * 0.10;
                    }
                    else if (days > 10 && days <= 15)
                    {
                        sumNights = (nights * 35.00) - (nights * 35.00) * 0.15;
                    }
                    else if (days > 15)
                    {
                        sumNights = (nights * 35.00) - (nights * 35.00) * 0.20;
                    }
                }
                if (rating == "positive")
                {
                    sumNights = sumNights + (sumNights * 0.25);
                    Console.WriteLine($"{sumNights:f2}");
                }
                else if (rating == "negative")
                {
                    sumNights = sumNights - (sumNights * 0.10);
                    Console.WriteLine($"{sumNights:f2}");
                }
            }
        }
    }
}
