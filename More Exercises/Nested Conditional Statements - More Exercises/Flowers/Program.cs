using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            double chrysanthemums = double.Parse(Console.ReadLine());
            double roses = double.Parse(Console.ReadLine());
            double tulips = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string feast = Console.ReadLine();

            double finalSum = roses + tulips + chrysanthemums;
            double discount = 0;

            if (season == "Summer")
            {

                if (feast == "Y")
                {
                    chrysanthemums *= 2.00;
                    roses *= 4.10;
                    tulips *= 2.50;
                    discount = (chrysanthemums + roses + tulips) * 1.15;
                }
                else if (feast == "N")
                {
                    chrysanthemums *= 2.00;
                    roses *= 4.10;
                    tulips *= 2.50;
                    discount = (chrysanthemums + roses + tulips);
                }
            }
            else if (season == "Spring" && tulips > 7)
            {

                if (feast == "Y")
                {
                    chrysanthemums *= 2.00;
                    roses *= 4.10;
                    tulips *= 2.50;
                    discount = (chrysanthemums + roses + tulips) * 1.15;
                    discount *= 0.95;

                }
                else if (feast == "N")
                {
                    chrysanthemums *= 2.00;
                    roses *= 4.10;
                    tulips *= 2.50;
                    discount = (chrysanthemums + roses + tulips);
                    discount *= 0.95;
                }
            }
            else if (season == "Spring" && tulips < 7)
            {

                if (feast == "Y")
                {
                    chrysanthemums *= 2.00;
                    roses *= 4.10;
                    tulips *= 2.50;
                    discount = (chrysanthemums + roses + tulips) * 1.15;
                }
                else if (feast == "N")
                {
                    chrysanthemums *= 2.00;
                    roses *= 4.10;
                    tulips *= 2.50;
                    discount = (chrysanthemums + roses + tulips);
                }

            }
            else if (season == "Winter" && roses > 10)
            {

                if (feast == "Y")
                {
                    chrysanthemums *= 3.75;
                    roses *= 4.50;
                    tulips *= 4.15;
                    discount = (chrysanthemums + roses + tulips) * 1.15;
                    discount *= 0.90;
                }
                else if (feast == "N")
                {
                    chrysanthemums *= 3.75;
                    roses *= 4.50;
                    tulips *= 4.15;
                    discount = (chrysanthemums + roses + tulips);
                    discount *= 0.90;

                }
            }
            else if (season == "Winter")
            {

                if (feast == "Y")
                {
                    chrysanthemums *= 3.75;
                    roses *= 4.50;
                    tulips *= 4.15;
                    discount = (chrysanthemums + roses + tulips) * 1.15;
                }
                else if (feast == "N")
                {
                    chrysanthemums *= 3.75;
                    roses *= 4.50;
                    tulips *= 4.15;
                    discount = (chrysanthemums + roses + tulips);

                }

            }
            else if (season == "Autumn")
            {
                if (feast == "Y")
                {
                    chrysanthemums *= 3.75;
                    roses *= 4.50;
                    tulips *= 4.15;
                    discount = (chrysanthemums + roses + tulips) * 1.15;
                }
                else if (feast == "N")
                {
                    chrysanthemums *= 3.75;
                    roses *= 4.50;
                    tulips *= 4.15;
                    discount = (chrysanthemums + roses + tulips);
                }
            }
            if (finalSum > 20)
            {
                discount *= 0.80;
            }
            discount += 2;
            Console.WriteLine($"{discount:f2}");
        }
    }
}
