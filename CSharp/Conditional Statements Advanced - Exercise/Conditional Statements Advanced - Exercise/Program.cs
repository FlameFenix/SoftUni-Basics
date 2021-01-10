using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projections = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double columns = double.Parse(Console.ReadLine());

            double income = 0;
            if (projections == "Premiere")
            {
                income = rows * columns * 12.00;
            }
            else if (projections == "Normal")
            {
                income = rows * columns * 7.50;
            }
            else if (projections == "Discount")
            {
                income = rows * columns * 5.00;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
