using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int therest = int.Parse(Console.ReadLine());
            double sum1 = dogs * 2.5;
            double sum2 = therest * 4;
            double finalsum = sum1 + sum2;
            Console.WriteLine($"{finalsum} lv.");
        }
    }
}
