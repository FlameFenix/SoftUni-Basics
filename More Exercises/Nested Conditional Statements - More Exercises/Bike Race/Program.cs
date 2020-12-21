using System;

namespace Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string typeOfTrace = Console.ReadLine();
            int discount = juniors + seniors;
            double expenses = 0;
            double sumForJuniors = 0;
            double sumForSeniors = 0;
            double finalSum = 0;
            if (typeOfTrace == "trail" && discount < 50)
            {
                if (juniors > 0)
                {
                    sumForJuniors = juniors * 5.50;
                }
                if (seniors > 0)
                {
                    sumForSeniors = seniors * 7;
                }
            }
            else if (typeOfTrace == "cross-country" && discount >= 50)
            {
                if (juniors > 0)
                {
                    sumForJuniors = juniors * 8;
                    sumForJuniors *= 0.75;
                }
                if (seniors > 0)
                {
                    sumForSeniors = seniors * 9.50;
                    sumForSeniors *= 0.75;
                }
            }
            else if (typeOfTrace == "cross-country")
            {
                if (juniors > 0)
                {
                    sumForJuniors = juniors * 8.0;
                }
                if (seniors > 0)
                {
                    sumForSeniors = seniors * 9.50;
                }
            }
            else if (typeOfTrace == "downhill")
            {
                if (juniors > 0)
                {
                    sumForJuniors = juniors * 12.25;
                }
                if (seniors > 0)
                {
                    sumForSeniors = seniors * 13.75;
                }
            }
            else if (typeOfTrace == "road")
            {
                if (juniors > 0)
                {
                    sumForJuniors = juniors * 20;
                }
                if (seniors > 0)
                {
                    sumForSeniors = seniors * 21.50;
                }
            }
            finalSum = sumForSeniors + sumForJuniors;
            expenses = finalSum * 0.95;
            Console.WriteLine($"{expenses:f2}");
        }
    }
}
