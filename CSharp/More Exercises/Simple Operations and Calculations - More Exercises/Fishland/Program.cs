using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaSkum = double.Parse(Console.ReadLine());
            double cenaCaca = double.Parse(Console.ReadLine());
            double palamKg = double.Parse(Console.ReadLine());
            double safrKg = double.Parse(Console.ReadLine());
            double midKg = double.Parse(Console.ReadLine());

            double cenaPalam = cenaSkum + cenaSkum * 0.6;
            double sumPalam = palamKg * cenaPalam;

            double cenaSaf = cenaCaca + cenaCaca * 0.8;
            double sumSaf = safrKg * cenaSaf;

            double sumMid = midKg * 7.50;

            double totalsum = sumPalam + sumSaf + sumMid;

            Console.WriteLine($"{totalsum:F2}");
        }
    }
}
