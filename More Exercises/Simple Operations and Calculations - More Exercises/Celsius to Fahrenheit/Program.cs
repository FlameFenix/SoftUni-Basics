using System;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double cel = double.Parse(Console.ReadLine());

            double fahr = (cel * 9 / 5) + 32;

            Console.WriteLine($"{fahr:F2}");
        }
    }
}
