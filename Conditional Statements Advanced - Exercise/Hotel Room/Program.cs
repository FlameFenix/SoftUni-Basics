using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int overnight = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;

            if (month == "May" || month == "October")
            {
                studio = 50;
                apartment = 65;
                if (overnight > 7 && overnight <= 14)
                {
                    studio *= overnight * 0.95;
                    apartment *= overnight;
                }
                else if (overnight > 14)
                {
                    studio *= overnight * 0.70;
                    apartment *= overnight * 0.90;
                }
                else
                {
                    studio *= overnight;
                    apartment *= overnight;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20;
                apartment = 68.70;
                if (overnight > 7 && overnight <= 14)
                {
                    studio *= overnight;
                    apartment *= overnight;
                }
                else if (overnight > 14)
                {
                    studio *= overnight * 0.80;
                    apartment *= overnight * 0.90;
                }
                else
                {
                    studio *= overnight;
                    apartment *= overnight;
                }
            }
            else if (month == "July" || month == "August")
            {
                studio = 76;
                apartment = 77;
                if (overnight > 7 && overnight <= 14)
                {
                    studio *= overnight;
                    apartment *= overnight;
                }
                else if (overnight > 14)
                {
                    studio *= overnight;
                    apartment *= overnight * 0.90;
                }
                else
                {
                    studio *= overnight;
                    apartment *= overnight;
                }
            }
            Console.WriteLine($"Apartment: {apartment:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}
