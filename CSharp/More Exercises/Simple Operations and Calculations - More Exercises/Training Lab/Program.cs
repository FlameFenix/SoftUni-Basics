using System;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthInMeteres = double.Parse(Console.ReadLine());
            double heightInMeters = double.Parse(Console.ReadLine());

            widthInMeteres = widthInMeteres * 100;
            heightInMeters = heightInMeters * 100;

            double heightWithCorridor = heightInMeters - 100;

            double widthSeats = Math.Floor(widthInMeteres / 120);
            double heightSeats = Math.Floor(heightWithCorridor / 70);

            double totalSeats = widthSeats * heightSeats - 3;

            Console.WriteLine($"{totalSeats}");
        }
    }
}
