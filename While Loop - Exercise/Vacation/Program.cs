using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyVacation = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            double countDays = 0;
            int spendCount = 0;

            while (availableMoney < moneyVacation && spendCount < 5)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                countDays++;
                if (action == "save")
                {
                    availableMoney += money;
                    spendCount = 0;
                }
                else if (action == "spend")
                {
                    availableMoney -= money;
                    spendCount++;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
                if (spendCount == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{countDays}");
                }
                if (availableMoney >= moneyVacation)
                {
                    Console.WriteLine($"You saved the money for {countDays} days.");
                }
            }
        }
    }
}
