using System;

namespace Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string weather = null;
            weather = Console.ReadLine();

            if (weather == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (weather == "cloudy")
            {
                Console.WriteLine("It's cold outside!");
            }
            else if (weather == "snowy")
            {
                Console.WriteLine("It's cold outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
