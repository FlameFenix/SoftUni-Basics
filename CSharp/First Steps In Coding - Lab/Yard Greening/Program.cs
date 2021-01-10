using System;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double meter = double.Parse(Console.ReadLine());
            double price = meter * 7.61;
            double discount = 0.18 * price;
            double finalsum = price - discount;
            Console.WriteLine($"The Final Price is: {finalsum} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
