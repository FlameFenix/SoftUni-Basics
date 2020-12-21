using System;

namespace Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            double v = double.Parse(Console.ReadLine());
            double p1 = double.Parse(Console.ReadLine());
            double p2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double p1water = h * p1;
            double p2water = h * p2;

            double sumOfBothP = p1water + p2water;

            double sumOfBothInPercent = sumOfBothP / (v / 100);
            double sumForP1InPercent = p1water / (sumOfBothP / 100);
            double sumForP2InPercent = p2water / (sumOfBothP / 100);

            double overFlow = sumOfBothP - v;

            if (sumOfBothInPercent > 100.00)
            {
                Console.WriteLine($"For {h} hours the pool overflows with {overFlow} litters.");
            }
            else if (sumOfBothInPercent <= 100.00)
            {
                Console.WriteLine($"The pool is {sumOfBothInPercent:F2}% full. Pipe 1: {sumForP1InPercent:F2}%. Pipe 2: {sumForP2InPercent:F2}%.");
            }
        }
    }
}
