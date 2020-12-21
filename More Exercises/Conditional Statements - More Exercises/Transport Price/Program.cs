using System;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string typeOfDay = Console.ReadLine();

            double distanceSum = 0;

            if (distance < 20)
            {
                if (typeOfDay == "day")
                {
                    distanceSum = 0.70 + distance * 0.79;
                }
                else if (typeOfDay == "night")
                {
                    distanceSum = 0.70 + distance * 0.90;
                }
            }

            else if (distance >= 20 && distance < 100)
            {
                if (typeOfDay == "day")
                {
                    distanceSum = distance * 0.09;
                }
                else if (typeOfDay == "night")
                {
                    distanceSum = distance * 0.09;
                }
            }
            else if (distance >= 100)
            {
                if (typeOfDay == "day")
                {
                    distanceSum = distance * 0.06;
                }
                else if (typeOfDay == "night")
                {
                    distanceSum = distance * 0.06;
                }
            }
            Console.WriteLine($"{distanceSum:f2}");
        }
    }
}
