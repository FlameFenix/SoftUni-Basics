using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int LillysAge = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            int toysCount = 0;
            int MoneyForBirthday = 0;
            double priceForToys = 0;
            double finalSum = 0;

            string output = string.Empty;

            for (int i = 1; i <= LillysAge; i++)
            {
                if (i % 2 == 0)
                {
                    MoneyForBirthday += (10 * i) / 2 - 1;
                }
                else if (i % 2 != 0)
                {
                    toysCount += 1;
                }
            }
            priceForToys = toysCount * toysPrice;
            finalSum = priceForToys + MoneyForBirthday;
            if (washingMachine <= finalSum)
            {
                finalSum -= washingMachine;
                output = $"Yes! {finalSum:f2}";
            }
            else
            {
                finalSum -= washingMachine;
                output = $"No! {Math.Abs(finalSum):f2}";
            }
            Console.WriteLine(output);
        }
    }
}
